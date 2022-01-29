using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
	public float time = 10.0f;
	public bool canClose = false;
    void Update()
    {
    	time -= Time.deltaTime;
        if (time <= 0.0f){
        	timerEnded();
        }
    }

    void timerEnded(){
    	canClose = true;

    }
}
