using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour
{
	[SerializeField] public GameObject secondEndGoal;
	[SerializeField] private string newLevel;
	private bool thisBallActivated = false;
	private bool secondBallActivated = false;
	SecondEndGoalScript script;

	private void Awake() {
		script = secondEndGoal.GetComponent<SecondEndGoalScript>();
		script.newLevel = newLevel;
		//secondBallActivated = secondEndGoal.GetComponent<MoveScenes2D>().thisBallActivated;
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			thisBallActivated = true;
		}
		
		script.secondBallActivated = thisBallActivated;
		//Debug.Log(secondEndGoal);
		secondBallActivated = script.thisBallActivated;
		if(thisBallActivated&&secondBallActivated){
			SceneManager.LoadScene(newLevel);
		}
	}
}
