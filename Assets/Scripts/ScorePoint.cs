using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {
    public bool fish = false;
	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.tag == "Player") {
			Score.AddPoint();
            if (fish) { Score.AddFish(); Destroy(GameObject.Find("Fish")); }
            }
	}
}
