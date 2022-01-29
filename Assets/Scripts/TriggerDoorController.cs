using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    void OnCollisionEnter2D(Collision2D collision){
    	if(collision.gameObject.tag == "Interactable"){
    		Debug.Log("Hit");
    		myDoor.Play("DoorOpen", 0, 0.0f);
    	}
    }

}

//     private void onTriggerEnter(Collider other){
//     	if(other.CompareTag("Player")){
//     		if(openTrigger){
//     			myDoor.Play("DoorOpen", 0, 0.0f);
//     		}
//     		else if (closeTrigger){
//     			myDoor.Play("DoorClose", 0, 0.0f);
//     		}
//     	}
//     }
// }
