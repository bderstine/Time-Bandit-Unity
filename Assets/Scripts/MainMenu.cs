using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public InputField nameField;
	public static string myName;

	public void SubmitName(int sceneIndex) {
		myName = nameField.text;
		SceneManager.LoadScene (sceneIndex);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
