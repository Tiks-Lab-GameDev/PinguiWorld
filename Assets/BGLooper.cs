using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int numBGPanels = 6;

	float pipeMax = 0.8430938f;
	float pipeMin = -0.003243029f;

	void Start() {
		GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");

		foreach(GameObject pipe in pipes) {
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range(pipeMin, pipeMax);
			pipe.transform.position = pos;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("Triggered: " + collider.name);

		

		Vector3 pos = collider.transform.position;

		float widthOfBGObject = ((BoxCollider2D)collider).size.x;


				if (collider.tag == "Pipe") {
						pos.y = Random.Range (pipeMin, pipeMax);
						pos.x += widthOfBGObject * numBGPanels;
				} else {
						if (collider.tag == "BG") {
								pos.x += (widthOfBGObject * collider.transform.lossyScale.x) * numBGPanels;
						} else 		pos.x += widthOfBGObject * numBGPanels;
				}
						

		collider.transform.position = pos;

	}
}
