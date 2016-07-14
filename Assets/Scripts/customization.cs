using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class customization : MonoBehaviour {
    public Sprite[] hats;
    public int[] price;
    public string[] skins;
    public string[] glasses;
    SpriteRenderer sprite;
    int num;

    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        num = SaveScore.numOfHat;
        sprite.sprite = hats[num];
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void change()
    {
        sprite.sprite = hats[num];
    }

    public void plusNum()
    {
        if (num == hats.Length-1) num = 0;
        else num += 1;
        change();
    }

    public void minusNum()
    {
        if (num == 0) num = hats.Length - 1;
        else num -= 1;
        change();
    }
    public void save()
    {
        if (!buy()) return;
        else
        {
            SaveScore.numOfHat = num;
            SaveScore.Save();
        }
    }

    bool buy()
    {
        if (SaveScore.fish >= price[num]) { SaveScore.fish = SaveScore.fish - price[num]; return true;}
        else return false;
    }
}
