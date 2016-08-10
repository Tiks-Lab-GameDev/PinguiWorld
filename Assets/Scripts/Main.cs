using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
    SaveScore ss;
    private int maxhp, hp, score, gf, highscore, hat;
    private float volume;
    private bool isPause, isReview, dead, godmode, start;

    public int Maxhp
    {
        get
        {
            return maxhp;
        }

        set
        {
            maxhp = value;
        }
    }

    public int Hp
    {
        get
        {
            return hp;
        }

        set
        {
            hp = value;
        }
    }

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public int Gf
    {
        get
        {
            return gf;
        }

        set
        {
            gf = value;
        }
    }

    public bool IsPause
    {
        get
        {
            return isPause;
        }

        set
        {
            isPause = value;
        }
    }

    public int Highscore
    {
        get
        {
            return highscore;
        }

        set
        {
            highscore = value;
        }
    }

    public float Volume
    {
        get
        {
            return volume;
        }

        set
        {
            volume = value;
        }
    }

    public int Hat
    {
        get
        {
            return hat;
        }

        set
        {
            hat = value;
        }
    }

    public bool IsReview
    {
        get
        {
            return isReview;
        }

        set
        {
            isReview = value;
        }
    }

    public bool Dead
    {
        get
        {
            return dead;
        }

        set
        {
            dead = value;
        }
    }

    public bool Godmode
    {
        get
        {
            return godmode;
        }

        set
        {
            godmode = value;
        }
    }

    public bool IsStart
    {
        get
        {
            return start;
        }

        set
        {
            start = value;
        }
    }

    void Start () {}

    void Update() { }
}
