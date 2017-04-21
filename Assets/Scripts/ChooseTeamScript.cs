using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseTeamScript : MonoBehaviour {
	
	public Text welcome_text;

	// Use this for initialization
	void Start () {
		Debug.Log(MainMenu.myName);
		welcome_text.text = "Welcome " + MainMenu.myName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
