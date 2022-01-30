using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    private bool canBeActivated;
    public bool activated = false;
    public GameObject stand;

    bool firstTimeHuhQuestionMarkHaHaMeeeeemeees = true;
    private Color IColor;
    public string buttonAnimationOpenName = "";
    public string buttonAnimationCloseName = "";



    Renderer rend;
    // Update is called once per frame
    private void Awake() {
        rend = GetComponent<Renderer>();
        IColor = rend.material.color;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        canBeActivated = stand.GetComponent<ButtonStand>().activated;

        highlight();
        if(canBeActivated){
            if (Input.GetKeyUp(KeyCode.E)){
                activated = !activated;
            }
        }

        if(activated){
            firstTimeHuhQuestionMarkHaHaMeeeeemeees = false;
            Debug.Log("animation is playing");
            anim.Play(buttonAnimationOpenName);
        }
        else if(!firstTimeHuhQuestionMarkHaHaMeeeeemeees){
            Debug.Log("reversed animation is playing");
            anim.Play(buttonAnimationCloseName);
        }
        
    }

    // private void OnGUI() {

    //     if(canBeActivated){
    //         if (Input.GetKeyUp(KeyCode.E))
    //         {
    //             Debug.Log(active);
    //             active = !active;
    //         }
    //     }
        
    // }
    private void highlight(){
        
        if(canBeActivated){
            rend.material.color = new Color(0.4f,0.1f,0.1f);
        }
        else{
            rend.material.color = IColor;
        }
        // Debug.Log(canBeActivated);
    }
}
