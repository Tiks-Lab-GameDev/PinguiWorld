using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class ChooseHat : MonoBehaviour
{

    public GameObject[] hats;
    SpriteRenderer sprite;
    Main main;
    int num;
    GameObject go,pl;
    // Use this for initialization
    void Start () {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        num = PlayerPrefs.GetInt("NumOfHat");
        pl = GameObject.Find("PlayerBird");
        DrawHat();
        go.transform.SetParent(pl.transform);
    }
	
	// Update is called once per frame
    void DrawHat()
    {
        go = GameObject.Find(Instantiate(hats[num], hats[num].transform.position, hats[num].transform.rotation).name);
    }
}
