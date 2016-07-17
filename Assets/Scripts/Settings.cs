using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("GodMode", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void GodMod()
    {
        if (PlayerPrefs.GetInt("GodMode") == 0)
        {
            PlayerPrefs.SetInt("GodMode", 1);
        }
        else PlayerPrefs.SetInt("GodMode", 0);
        Debug.Log(PlayerPrefs.GetInt("GodMode"));
    }

}
