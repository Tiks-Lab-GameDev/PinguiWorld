using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System;

public class customization : MonoBehaviour {
    public Sprite[] hats;
    public int[] price;
    bool[] isBuy;
    public string[] skins;
    public string[] glasses;
    SpriteRenderer sprite;
    int size,num;
    Main main;
    SaveScore ss;

    // Use this for initialization
    void Start () {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        ss = GameObject.Find("Scripts").GetComponent<SaveScore>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = hats[main.Hat];
        size = hats.Length;
        isBuy = new bool[size];
        fishUpdate();
    }

    // Update is called once per frame
    void Update () {
    }

    void change()
    {
        sprite.sprite = hats[num];
        main.Hat = num;
        fishUpdate();
    }

    public void plusNum()
    {
        if (num == size-1) num = 0;
        else num += 1;
        change();
    }

    public void minusNum()
    {
        if (num == 0) num = size - 1;
        else num -= 1;
        change();
    }
    public void save()
    {
        if (!buy()) { GameObject.Find("UIManager").GetComponent<UiManager>().CloseErorr(); return; }
        else
        {
            main.Maxhp = main.Hat;
            ss.Save();
            fishUpdate();
            GameObject.Find("UIManager").GetComponent<UiManager>().CloseBuy();
        }
    }

    bool buy()
    {
        //if (isBuy[num] == false) return false;
        //Debug.Log(Gf);
        if (main.Gf >= price[main.Hat]) { main.Gf = main.Gf - price[main.Hat]; return true;}
        else return false;
    }

    void fishUpdate()
    {
        GameObject.Find("Price").GetComponent<Text>().text = "Fish: " + main.Gf + "\nPrice: " + price[main.Hat];
    }
}
