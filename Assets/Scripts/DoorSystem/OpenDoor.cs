using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator anim;
    [SerializeField] GameObject pressPlate;
    private bool open = false;
    private bool firstTimeHuh = true;
    private float timer = -0.5f;
    public string animationOpenName = "";
    public string animationCloseName = "";
    public string componentType = "";
    private void Awake() {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        bool active;
        if(componentType == "plate"){
            active = pressPlate.GetComponent<PlateTrigger>().activated;
        }
        else{
            active = pressPlate.GetComponent<ButtonTrigger>().activated;
        }
        
        
        
        
        timer -= Time.deltaTime;

       // Debug.Log(open);

        if(active){
            timer = 3.0f;
            open = true;
        } else if(!active){
           // timer = 3.0f;
        }
        if(timer<=0.0f&&timer>=-1.0f){

            timer = 1.0f;
            open = false;
        }

        if(open){
            //anim.Play("PressurePlateDown");
    	    anim.Play(animationOpenName);
            firstTimeHuh = false;
        }else if (!firstTimeHuh){
            anim.Play(animationCloseName);
        }
    }
}
