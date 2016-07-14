using UnityEngine;
using System;
using System.Text;
using System.IO;

public class Score : MonoBehaviour {

    public static int score, highScore, fish, sc = 0;

    static public void AddPoint() {
		if(BirdMovement.dead) return;
        score++;
		if(score > highScore) {
			highScore = score;
		}
	}

    void Start() {
        score = sc;
    }

	void Update () {
		GetComponent<GUIText>().text = "Score: " + score + "\nHigh Score: " + highScore +"\nGold Fish: "+ fish + "\nHp:"+BirdMovement.hp;
	}

    public static void SaveScore()
    {
        if (BirdMovement.isReview)
        {
            sc = score;
        }
        else Score.sc = 0;
    }


    public static void AddFish()
    {
        fish++;
    }

}
