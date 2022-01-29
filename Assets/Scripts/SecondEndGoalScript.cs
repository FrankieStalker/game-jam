using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondEndGoalScript : MonoBehaviour
{
	public bool thisBallActivated = false;
    public bool secondBallActivated = false;

    public string newLevel;

	private void Awake() {
      //  thisBallActivated = false;
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			thisBallActivated = true;
		}

        if(thisBallActivated&&secondBallActivated){
			SceneManager.LoadScene(newLevel);
		}
	}
}
