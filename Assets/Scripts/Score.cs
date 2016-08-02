using UnityEngine;

public class Score : MonoBehaviour {

    int sc = 0;
    Main main;

    void Start() {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        main.Score = sc;
        sc = 0;
    }

	void Update () {
		GetComponent<GUIText>().text = "Score: " + main.Score + "\nHigh Score: " + main.Highscore + "\nGold Fish: "+ main.Gf + "\nHp:"+ main.Hp;
	}

    public void SaveSc()
    {
        if (main.IsReview)
        {
            sc = main.Score;
        }
        else sc = 0;
    }

}
