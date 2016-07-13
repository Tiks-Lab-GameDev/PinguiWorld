using UnityEngine;
using System.Collections;
public class PikCrack : MonoBehaviour {
	bool iscrack = false;
	public static GameObject go;
	public static float posx,posy;
	// Use this for initialization
	void Start () {
		go = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			posx = GetComponent<Transform> ().position.x;
			posy = GetComponent<Transform> ().position.y;
			GameObject.FindGameObjectWithTag("Pik").GetComponent<Animation>().Play();
            Destroy (this.gameObject);
		}
	}
}
