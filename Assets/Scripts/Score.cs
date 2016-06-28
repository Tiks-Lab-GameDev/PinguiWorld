using UnityEngine;
using System;
using System.Text;
using System.IO;

public class Score : MonoBehaviour {

	public static int score, highScore, numOfSkin, fish, numOfHat, numOfGlasses, sc = 0;
	private static string[] Data;
    static Score instance;
    BirdMovement bird;
    static string path = "Save/001.dat";

    static public void AddPoint() {
		if(instance.bird.dead) return;
        score++;
		if(score > highScore) {
			highScore = score;
		}
	}

    void Start() {
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        instance = this;
		bird = player_go.GetComponent<BirdMovement>();
		score = sc;
        Directory.CreateDirectory("Save");
        highScore = GetSaveData(1);
		fish = GetSaveData(2);
        numOfHat = GetSaveData(3);
        numOfSkin = GetSaveData(4);
        numOfGlasses = GetSaveData(5);
    }
    
	void OnDestroy() {
		instance = null;
	}

	void Update () {
		GetComponent<GUIText>().text = "Score: " + score + "\nHigh Score: " + highScore +"\nGold Fish: "+ fish + "\nHp:"+bird.hp;
	}

	public static void SaveScore() {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        BirdMovement bird = player_go.GetComponent<BirdMovement>();
        File.Delete(path);                                                  // Удаляем файл с сохранением(костыль)
		File.AppendAllText(path,"highScore= " + highScore + ";");               // Записываем данные
		File.AppendAllText(path,"fish= " + fish + ";");
		File.AppendAllText(path,"numOfHat= "+numOfHat + ";");
        File.AppendAllText(path,"numOfSkin= " + numOfSkin + ";");
        File.AppendAllText(path,"numOfGlasses= " + numOfGlasses + ";");

    }

    void ChooseData(String name)
    {
        switch (name)
        {
            case "highscore":
                GetSaveData(1);
                break;
            case "fish":
                GetSaveData(2);
                break;
            case "numOfHat":
                GetSaveData(3);
                break;
            case "numOfSkin":
                GetSaveData(4);
                break;
            case "numOfGlasses":
                GetSaveData(5);
                break;
        }
    }

    public static int GetSaveData(int num) {
        string readStr = File.ReadAllText(path);
        int lstr = readStr.Length;
        string resultStr = "";
        int index = 0;
        for (int i = 0; i < num; i++){
            index = readStr.IndexOf(" ");           //Находим нужное значение
            readStr = readStr.Remove(0, index + 1);
        }
        index = readStr.IndexOf(";");
        int j = 0;
        while (j < index) { resultStr += readStr[j]; j++; }
        return Convert.ToInt32(resultStr);
    }
}
