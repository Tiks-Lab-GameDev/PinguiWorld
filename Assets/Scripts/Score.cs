using UnityEngine;

public class Score : MonoBehaviour {

    Main main;

    void Start() {
        main = GameObject.Find("Scripts").GetComponent<Main>();
    }

	void OnGUI () {
		GetComponent<GUIText>().text = "Score: " + main.Score + "\nHigh Score: " + main.Highscore + "\nGold Fish: "+ main.Gf + "\nHp:"+ main.Hp;
	}

}
