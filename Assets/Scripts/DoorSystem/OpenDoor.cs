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
    void Update()
    {
        bool active = pressPlate.GetComponent<PlateTrigger>().activated;
        if(active&&!open){
    	     anim.Play("DoorOpen", 0, 0.0f);
             open = true;
        } else if(!active&&open){
            open = false;
            
        }
    }
}
