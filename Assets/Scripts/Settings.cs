using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
	// Use this for initialization
	void Start () {

    }
	// Update is called once per frame
	void Update () {

    }
    public void GodMod()
    {
        
    }
    public void VolumeSwitch()
    {
        PlayerPrefs.SetFloat("Volume",GetComponent<Slider>().value);
        AudioListener.volume = 5;
    }
    void Change() {
        if (GameObject.Find("GodModeToggle").GetComponent<Toggle>().isOn)  PlayerPrefs.SetInt("GodMode", 0);
        else PlayerPrefs.SetInt("GodMode", 1);
    }
}
