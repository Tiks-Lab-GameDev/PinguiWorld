using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class customization : MonoBehaviour {
    public Sprite[] hats;
    public string[] skins;
    public string[] glasses;
    SpriteRenderer sprite;
    int num;

    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        num = Convert.ToInt32(File.ReadAllText("save/002.dat"));
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
        File.Delete("save/002.dat");
        File.WriteAllText("save/002.dat", Convert.ToString(num));
    }
}
