using UnityEngine;
using System;
using System.Text;
using System.IO;

public class Score : MonoBehaviour {

    public static int score, sc = 0;

    static public void AddPoint() {
		if(BirdMovement.dead) return;
        score++;
         GameObject.Find("Point_sound").GetComponent<AudioSource>().Play();
        if (score > SaveScore.highScore) {
            SaveScore.highScore = score;
        }
    }

    void Start() {
        SaveScore.GetData();
        score = sc;
        sc = 0;
    }

	void Update () {
		GetComponent<GUIText>().text = "Score: " + score + "\nHigh Score: " + SaveScore.highScore + "\nGold Fish: "+ SaveScore.fish + "\nHp:"+BirdMovement.hp;
	}

    public static void SaveSc()
    {
        if (BirdMovement.isReview)
        {
            sc = score;
        }
        else Score.sc = 0;
    }


    public static void AddFish()
    {
        SaveScore.fish++;
    }

}
