using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseTeamScript : MonoBehaviour {
	
	public Text welcome_text;
	public static string myTeam;

	public void ChooseThief(int sceneIndex) {
		myTeam = "Thief";
		SceneManager.LoadScene (sceneIndex);
	}

	public void ChooseDetective(int sceneIndex) {
		myTeam = "Detective";
		SceneManager.LoadScene (sceneIndex);
	}

	// Use this for initialization
	void Start () {
		//Debug.Log(MainMenu.myName);
		welcome_text.text = "Welcome " + MainMenu.myName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
