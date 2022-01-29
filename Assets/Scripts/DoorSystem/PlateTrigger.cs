using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    private BoxCollider2D boxCollider; // Box collider of the player. Facilitates collision detection.
    [SerializeField] private LayerMask playerLayer; 
    [SerializeField] public bool activated = false;


    private void Awake() {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if(onPlayer()){
            activated = true;
        //Debug.Log("Works");
        }
        else{
            activated = false;
        }
    }

    private bool onPlayer(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.up, 0.1f, playerLayer);
        
        return raycastHit.collider != null;
    }
}
