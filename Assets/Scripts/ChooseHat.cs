using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class ChooseHat : MonoBehaviour {

    int HatIndex;
    public Sprite[] hat;
    SpriteRenderer sprite;
    // Use this for initialization
    void Start () {
        HatIndex = Convert.ToInt32(File.ReadAllText("save/002.dat"));
        sprite = GetComponent<SpriteRenderer>();
        DrawHat();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void DrawHat()
    {
        sprite.sprite = hat[HatIndex];
    }
}
