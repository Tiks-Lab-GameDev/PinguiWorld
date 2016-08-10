using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Help : MonoBehaviour {

    public GameObject go;
    bool active;
	// Use this for initialization
	void Start () {
        GameObject.Find("Toggle").GetComponent<Toggle>().isOn = bool.Parse(PlayerPrefs.GetString("Active"));
        if (bool.Parse(PlayerPrefs.GetString("Active"))) Destroy(go);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ToggleActive()
    {
        active = !active;
        PlayerPrefs.SetString("Active", active.ToString());
    }

    public void Close()
    {
        Destroy(go);
    }
}
