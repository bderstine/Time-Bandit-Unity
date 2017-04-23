using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARCameraScript : MonoBehaviour {

	public void OpenScene (int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
	}

	// Use this for initialization
	void Start () {
		
	}

	public GameObject monitor;
	// Update is called once per frame
	void Update () {
		monitor = GameObject.Find("energyBlast");
		if (Input.GetMouseButtonDown(0)) {
			Ray toMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit rhInfo;
			bool didHit = Physics.Raycast(toMouse, out rhInfo, 500.0f);
			if (didHit) {
				Debug.Log(rhInfo.collider.name + " .. " + rhInfo.point);
				if (monitor) {
					SceneManager.LoadScene(2);
				}
			} else {
				Debug.Log("clicked on empty space");
			}
		}
	}
}
