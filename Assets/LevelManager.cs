using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager2 : MonoBehaviour
{
	private int lives = 3;
	public Transform spawnPosition;
	public Transform playerTransform;

	private void Update(){
		if(playerTransform.position.y < -15){
			playerTransform.position = spawnPosition.position;
			lives--;
			if (lives <=0){
				SceneManager.LoadScene("GameOver");
				Debug.Log("Dead");
			}
		}
	}
}
