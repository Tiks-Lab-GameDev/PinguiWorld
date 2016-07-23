using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {


    BirdMovement bird;
    public GameObject dbox, pbox;

    // Use this for initialization
    void Start () {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		bird = player_go.GetComponent<BirdMovement>();
        dbox = GameObject.Find("DeathBack");
        pbox = GameObject.Find("PauseMenu");
        pbox.SetActive(false);
        dbox.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnGUI (){
        if (BirdMovement.dead) deadGui();
        if (!bird.start) { if (bird.IsPause) pbox.SetActive(true); }
        if (pbox.active && !bird.IsPause) pbox.SetActive(false);
    }
    
    void deadGui() {
        dbox.SetActive(true);
    }
}
