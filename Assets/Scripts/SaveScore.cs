using UnityEngine;
using System;

public class SaveScore : MonoBehaviour
{

    string HighScore = "HighScore", Skin = "NumOfSkin", Fish = "Fish", NumHat = "NumOfHat", Glasses = "NumOfGlasses", MaxHp = "MaxHp", Vol = "Volume";
    Main main;

    // Use this for initialization
    void Start () {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        GetData();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    //move to data.cs
    public void GetData()
    {
        main.Highscore = PlayerPrefs.GetInt("HighScore");
        main.Gf = PlayerPrefs.GetInt("Fish");
        main.Hat = PlayerPrefs.GetInt("NumOfHat");
        // numOfSkin = PlayerPrefs.GetInt(Skin);
        // numOfGlasses = PlayerPrefs.GetInt(Glasses);
        main.Maxhp = PlayerPrefs.GetInt("MaxHp");
        main.Volume = PlayerPrefs.GetFloat("Volume");
        main.Hp = main.Maxhp;
        main.Score = 0;
        main.IsPause = true;
        main.IsReview = true;
        main.Dead = false;
        main.Godmode = false;
        main.IsStart = true;
    }
    //end

    void SaveAll()
    {
        PlayerPrefs.SetInt(HighScore, main.Highscore);
        PlayerPrefs.SetInt(Fish, main.Gf);
     //   PlayerPrefs.SetInt(Skin, numOfSkin);
        PlayerPrefs.SetInt(NumHat, main.Hat);
      //  PlayerPrefs.SetInt(Glasses, numOfGlasses);
        PlayerPrefs.SetInt(MaxHp, main.Maxhp);
        PlayerPrefs.SetFloat(Vol, main.Volume);
    }
    /// <summary>
    /// save all data
    /// </summary>
    public void Save()
    {
        PlayerPrefs.Save();
        SaveAll();
    }

    public void AddFish()
    {
        main.Gf++;
        Save();
    }

    public void AddPoint()
    {
        main.Score++;
        GameObject.Find("Point_sound").GetComponent<AudioSource>().Play();
        if (main.Score > main.Highscore) main.Highscore = main.Score;
    }
    public void Revive()
    {
        if (main.IsReview) { }
    }
}
