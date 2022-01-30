using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvLpuzzleLogic : MonoBehaviour
{
    public GameObject Trigger1;
    public GameObject Trigger2;

    private ButtonTrigger thisScript;
    private ButtonTrigger script1;
    private ButtonTrigger script2;

    private Renderer rend; 

    private void Awake() {
        rend = GetComponent<Renderer>();
        thisScript = GetComponent<ButtonTrigger>();
        script1 = Trigger1.GetComponent<ButtonTrigger>();
        script2 = Trigger2.GetComponent<ButtonTrigger>();
    }
    private void Update() {

        if(thisScript.activated){
            if(script1.activated){
                script1.activated = false;
            }
            if(script2.activated){
                script2.activated = false;
            }

        }
        
    }
}
