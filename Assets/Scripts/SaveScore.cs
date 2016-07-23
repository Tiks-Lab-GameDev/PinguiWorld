using UnityEngine;
using System.Collections;

public class SaveScore : MonoBehaviour {

    public static int score, highScore, numOfSkin, fish, numOfHat, numOfGlasses, maxHp, sc = 0;
    public static float volume;
    public static string HighScore = "HighScore", Skin = "NumOfSkin", Fish = "Fish", Hat = "NumOfHat", Glasses = "NumOfGlasses", MaxHp = "MaxHp", Volume = "Volume";
    // Use this for initialization
    void Start () {
        GetData();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void GetData()
    {
        highScore = PlayerPrefs.GetInt(HighScore);
        fish = PlayerPrefs.GetInt(Fish);
        numOfHat = PlayerPrefs.GetInt(Hat);
        numOfSkin = PlayerPrefs.GetInt(Skin);
        numOfGlasses = PlayerPrefs.GetInt(Glasses);
        maxHp = PlayerPrefs.GetInt(MaxHp);
        volume = PlayerPrefs.GetFloat(Volume);
    }

    public static void SaveAll()
    {
        PlayerPrefs.SetInt(HighScore, highScore);
        PlayerPrefs.SetInt(Fish, fish);
        PlayerPrefs.SetInt(Skin, numOfSkin);
        PlayerPrefs.SetInt(Hat, numOfHat);
        PlayerPrefs.SetInt(Glasses, numOfGlasses);
        PlayerPrefs.SetInt(MaxHp, maxHp);
        PlayerPrefs.SetFloat(Volume, volume);
    }

    public static void Save()
    {
        PlayerPrefs.Save();
        SaveAll();
    }
}
