using UnityEngine;
using System.Collections;

public class SaveScore : MonoBehaviour {

    public static int score, highScore, numOfSkin, fish, numOfHat, numOfGlasses, maxHp, sc = 0;
    public static string HighScore = "HighScore", Skin = "NumOfSkin", Fish = "Fish", Hat = "NumOfHat", Glasses = "NumOfGlasses", MaxHp = "MaxHp";
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void GetData(string name)
    {
        highScore = PlayerPrefs.GetInt(HighScore, 0);
        fish = PlayerPrefs.GetInt(Fish, 0);
        numOfHat = PlayerPrefs.GetInt(Hat, 0);
        numOfSkin = PlayerPrefs.GetInt(Skin, 0);
        numOfGlasses = PlayerPrefs.GetInt(Glasses, 0);
        maxHp = PlayerPrefs.GetInt(MaxHp, 0);
    }

    public static void Save()
    {
        PlayerPrefs.SetInt(HighScore, highScore);
        PlayerPrefs.SetInt(Fish, fish);
        PlayerPrefs.SetInt(Skin, numOfSkin);
        PlayerPrefs.SetInt(Hat, numOfHat);
        PlayerPrefs.SetInt(Glasses, numOfGlasses);
        PlayerPrefs.SetInt(MaxHp, maxHp);
    }
}
