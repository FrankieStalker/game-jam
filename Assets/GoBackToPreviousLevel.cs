using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GoBackToPreviousLevel : MonoBehaviour
{
	public void setLevel (string levelName){
		SceneManager.LoadScene(levelName);
	}
}
