using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed = 1; // speed of the player
    [SerializeField] public float JumpPower = 0.5f; // speed of the player
    [SerializeField] private LayerMask groundLayer; // ground layer variable that facilitates raycasting that facilitate collision detection on jump
    [SerializeField] private LayerMask WallLayer; // Wall layer variable that facilitates raycasting that facilitate collision detection on wall jump
    private Rigidbody2D body; // physics body of the palyer
    private Animator anim; // animator facilitates animations. mainly used to traverse states in state machine
    private BoxCollider2D boxCollider; // Box collider of the player. Facilitates collision detection.
    private float wallJumpCooldown;
    public Vector3 scale;
    float horizInput;
    // On creation
    private void Awake() {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Every frame
    private void Update() {
        //transform.localPosition;
        horizInput = Input.GetAxis("Horizontal"); // get horizontal axis input 

      
        // Facilitates *flipping* of the sprite
        if(horizInput>0.01f)
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        else if(horizInput<-0.01f)
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        
        

        // used to facilitate state transision
        anim.SetBool("walk", horizInput !=0); // walk if x axis input is not equals to zero
        anim.SetBool("grounded", isGrounded()); // grounded...

        Debug.Log(isGrounded());
        body.velocity = new Vector2(horizInput * speed,body.velocity.y); // facilitate movement right and left (D and A)
        
        //Jump if is grounded and space is pressend
        if(Input.GetKey(KeyCode.Space) )
            Jump();
        wallJumpCooldown += Time.deltaTime;

    }
    
private void Jump(){
    if(isGrounded()){
        body.velocity = new Vector2(body.velocity.x, JumpPower);// realistic physsics jumping , depends on the speed and velocity on x axis
        anim.SetTrigger("jump"); // trigger jumping state
        // grounded = false;
    }
}



//Returns whether the player is grounded using boxcasting
private bool isGrounded(){
    // returns whether the box collider that points down hits an object with the tag stored in serialized GroundLayer var
    RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
    // return whether the boxCollider actually hits the groundLayer. So returns true, if it is not equal to zero.
    return raycastHit.collider != null;
    
}

}

