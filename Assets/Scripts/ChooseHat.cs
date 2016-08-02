using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class ChooseHat : MonoBehaviour
{

    public Sprite[] hats;
    SpriteRenderer sprite;
    Main main;
    // Use this for initialization
    void Start () {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        sprite = GetComponent<SpriteRenderer>();
        DrawHat();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void DrawHat()
    {
        sprite.sprite = hats[main.Hat];
    }
}
