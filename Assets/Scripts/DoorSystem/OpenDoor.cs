using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator anim;
    [SerializeField] GameObject pressPlate;
    private bool open = false;
    private void Awake() {
        anim = GetComponent<Animator>();
    }
    public int timer = 10;
    void Update()
    {
        bool active = pressPlate.GetComponent<PlateTrigger>().activated;

        if(active&&!open){
            anim.Play("PressurePlateDown");
            while(timer > 0){
    	     anim.Play("DoorOpen");
             open = true;
             timer -= timer;
         }
            if(timer == 0){
                //anim.Play("DoorClose");
            }
        } else if(!active&&open){
            open = false;
            
        }
    }
}
