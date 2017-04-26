using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommonScript : MonoBehaviour {

	public void LoadScene(int sceneIndex){
		SceneManager.LoadScene (sceneIndex);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
