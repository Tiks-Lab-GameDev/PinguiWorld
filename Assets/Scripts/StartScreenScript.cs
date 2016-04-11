using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {


    BirdMovement bird;
    public GameObject dbox;
    bool save;
    string path = "Save/001.dat";

    // Use this for initialization
    void Start () {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		bird = player_go.GetComponent<BirdMovement>();
        dbox = GameObject.Find("DeathBack");
        dbox.SetActive(false);
        save = false;
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnGUI (){
            if (bird.dead) deadGui();
		}
    
    void deadGui() {
        dbox.SetActive(true);
        if (!save) { Score.SaveScore(path); save = true; }
    }
}
