using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {

	static bool sawOnce = false;
    float width = Screen.width;
    float height = Screen.height;
    int EndScore = Score.score;
    BirdMovement bird;
    public GameObject dbox;


    // Use this for initialization
    void Start () {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		bird = player_go.GetComponent<BirdMovement>();
        dbox = GameObject.Find("DeathBack");
        dbox.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnGUI (){
            if (bird.dead) deadGui();
		}
    
    void deadGui() {

        dbox.SetActive(true);
    }
}
