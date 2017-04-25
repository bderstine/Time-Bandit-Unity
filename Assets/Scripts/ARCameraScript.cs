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

	Vector3 touchPosWorld;
	TouchPhase touchPhase = TouchPhase.Began;
	void Update() {
		//We check if we have more than one touch happening.
		//We also check if the first touches phase is Ended (that the finger was lifted)
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase) {
			//We transform the touch position into word space from screen space and store it.
			touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

			Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

			//We now raycast with this information. If we have hit something we can process it.
			RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

			if (hitInformation.collider != null) {
				//We should have hit something with a 2D Physics collider!
				GameObject touchedObject = hitInformation.transform.gameObject;
				//touchedObject should be the object someone touched.
				Debug.Log("Touched " + touchedObject.transform.name);
			}
		}
	}

}
