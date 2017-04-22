using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour {

	public Text myname_text;
	public Text myteam_text;

	// Use this for initialization
	void Start () {
		myname_text.text = "Name: " + MainMenu.myName;
		myteam_text.text = "Team: " + ChooseTeamScript.myTeam;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
