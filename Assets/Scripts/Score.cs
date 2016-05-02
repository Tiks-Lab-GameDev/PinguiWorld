﻿using UnityEngine;
using System;
using System.Text;
using System.IO;

public class Score : MonoBehaviour {

	public static int score = 0;
    public static int sc = 0;
	static int highScore = 0;
    static int fish = 0;


    static Score instance;

	//public void IncreaseScore (int amount);

	static public void AddPoint() {
		if(instance.bird.dead)
			return;

		score++;

		if(score > highScore) {
			highScore = score;
		}
	}

	BirdMovement bird;
    string path = "Save/001.dat";


    void Start() {
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        instance = this;
		bird = player_go.GetComponent<BirdMovement>();
		score = sc;
        highScore = GetHighScore();
        Directory.CreateDirectory("Save");

    }
    
	void OnDestroy() {
		instance = null;
		PlayerPrefs.SetInt("highScore", highScore);
	}

	void Update () {
		GetComponent<GUIText>().text = "Score: " + score + "\nHigh Score: " + highScore +"\nGold Fish: "+ fish;
	}

    public static void SaveScore(string path) {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        BirdMovement bird = player_go.GetComponent<BirdMovement>();
        File.Delete(path);
        
        File.WriteAllText(path, "high score = " + highScore);
    }

    public static int GetHighScore() {
        string hscore = File.ReadAllText("Save/001.dat");
        int lscore = hscore.Length;
        string hs = "";
        for (int i = 13; i < lscore; i++)
        {
            hs += Convert.ToString(hscore[i]);
        }

        return Convert.ToInt32(hs); }
}
