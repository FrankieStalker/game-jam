using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour
{
	[SerializeField] private string newLevel;
	private bool player1Ready = false;
	private bool player2Ready = false;

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			player1Ready = true;
		}
		else if(other.CompareTag("Player2")){
			player2Ready = true;
		}
		if(player1Ready == true && player2Ready == true){
		SceneManager.LoadScene(newLevel);
	}
	}
}
