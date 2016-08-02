using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour
{

    public GameObject dbox, pbox;
    Main main;

    // Use this for initialization
    void Start () {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        dbox = GameObject.Find("DeathBack");
        pbox = GameObject.Find("PauseMenu");
        pbox.SetActive(false);
        dbox.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnGUI (){
        if (main.Dead) deadGui();
        if (!main.IsStart) { if (main.IsPause) pbox.SetActive(true); }
        if (pbox.active && !main.IsPause) pbox.SetActive(false);
    }
    
    void deadGui() {
        dbox.SetActive(true);
    }
}
