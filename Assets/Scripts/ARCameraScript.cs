using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARCameraScript : MonoBehaviour {
	public float TouchTime;

	public void OpenScene (int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
	}

	// Use this for initialization
	void Start () {
		
	}

	Vector3 touchPosWorld;
	TouchPhase touchPhase = TouchPhase.Began;
	void Update() {

		Touch touch = Input.touches [0];

		if (touch.phase == TouchPhase.Began){
			TouchTime = Time.time;
		}

		if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled){
			if (Time.time - TouchTime <= 0.5){
				// do stuff as a tap​
				SceneManager.LoadScene (7);
			}
			else{
				// this is a long press or drag​
				SceneManager.LoadScene (16);
			}
		}
	}

}
