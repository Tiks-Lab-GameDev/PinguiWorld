using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {

    SaveScore ss;

    void Start()
    {
        ss = GameObject.Find("Scripts").GetComponent<SaveScore>();
    }

	void OnTriggerEnter2D(Collider2D collider) {

        if (collider.tag == "Player") {
			ss.AddPoint();
        }
	}
}
