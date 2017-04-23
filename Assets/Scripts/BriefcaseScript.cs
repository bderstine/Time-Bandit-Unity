using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BriefcaseScript : MonoBehaviour {

	public void OpenScene (int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

}
