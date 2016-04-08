using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {

	static bool sawOnce = false;
		BirdMovement bird;


	// Use this for initialization
	void Start () {
		if(!sawOnce) {
			GetComponent<SpriteRenderer>().enabled = true;
			Time.timeScale = 0;
		}

		sawOnce = true;
				GameObject player_go = GameObject.FindGameObjectWithTag("Player");
				bird = player_go.GetComponent<BirdMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale==0 && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) ) {
			Time.timeScale = 1;
			GetComponent<SpriteRenderer>().enabled = false;
		}
	}
		void OnGUI (){
				int EndScore = Score.score;
				if (bird.dead) {
						GUI.Button (new Rect(Screen.width/2,Screen.height/2,Screen.width/10,Screen.height/10),"GameOver! \nYour Score: "+EndScore);
				} 
		}
}
