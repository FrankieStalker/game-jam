using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private bool canBeActivated;
    private bool activated = false;
    public GameObject stand;

    bool firstTimeHuhQuestionMarkHaHaMeeeeemeees = true;
    private Color IColor;



    Renderer rend;
    // Update is called once per frame
    private void Awake() {
        
        rend = GetComponent<Renderer>();
        IColor = rend.material.color;
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
            /*
                PLAY ANIMATION HERE of PRESSING BUTTON DOWN HERE
            */
        }
        else if(!firstTimeHuhQuestionMarkHaHaMeeeeemeees){
            Debug.Log("reversed animation is playing");
            /*
                PLAY ANIMATION HERE of DE_PRESSING BUTTON DOWN HERE
            */
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
