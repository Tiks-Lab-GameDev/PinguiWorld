using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour {

    public static string level;
    bool start;
    static int ite = 0;
    AsyncOperation ao;
    // Use this for initialization
    void Start () {
        ADS.ShowInterstitial();
        ao = SceneManager.LoadSceneAsync(level);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    public static void loop()
    {
        if (ADS.ite != 3) ADS.ite += 1;
        else ADS.ite = 0;
    }
}
