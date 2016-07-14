using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class ChooseHat : MonoBehaviour {

    public Sprite[] hat;
    SpriteRenderer sprite;
    // Use this for initialization
    void Start () {
        SaveScore.GetData();
        sprite = GetComponent<SpriteRenderer>();
        DrawHat();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void DrawHat()
    {
        sprite.sprite = hat[SaveScore.numOfHat];
    }
}
