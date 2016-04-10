using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {

	static bool sawOnce = false;
		BirdMovement bird;


	// Use this for initialization
	void Start () {

				GameObject player_go = GameObject.FindGameObjectWithTag("Player");
				bird = player_go.GetComponent<BirdMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	}
		void OnGUI (){
				int EndScore = Score.score;
				if (bird.dead) {
						GUI.Button (new Rect(Screen.width/2 - Screen.width / 10, Screen.height/2- Screen.height / 10, Screen.width/10,Screen.height/10),"GameOver! \nYour Score: "+EndScore);
				} 
		}
}
