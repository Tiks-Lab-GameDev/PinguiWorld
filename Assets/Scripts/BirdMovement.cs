﻿using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class BirdMovement : MonoBehaviour {

    Animator animator;
    Rigidbody2D rb;
    public float flapSpeed = 100f;
	public float forwardSpeed = 1f;
    public bool IsPause = false;
	public bool IsGuiClick = false;
    public int godMode = PlayerPrefs.GetInt("GodMod");
    Collider2D pikColl;
    public bool dead = false;
    GameObject pik;
    bool didFlap = false;
    public bool isReview = true;
	public int maxHp = 2;
	public int hp = 2;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = transform.GetComponentInChildren<Animator>();
        IsPause = true;
        Time.timeScale = 0;
        pik = GameObject.FindGameObjectWithTag("Pik");
	}
		
	// Do Graphic & Input updates here
	void Update() {
        if(Input.GetMouseButtonDown(0) && !IsGuiClick ) {
		    didFlap = true;
        }
    }
	
	// Do physics engine updates here
	void FixedUpdate () {
        if(dead) return;
        move();
        if (didFlap) flap();
        rotation();

	}

	void OnCollisionEnter2D(Collision2D collision) {
        isHit(collision);
        Score.SaveScore();
    }

    void flap()
    {
        rb.AddForce(Vector2.up * flapSpeed);
        animator.SetTrigger("DoFlap");
        didFlap = false;
    }

    void rotation()
    {
        if (rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            float angle = Mathf.Lerp(0, -90, (-rb.velocity.y / 3f));
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    void move()
    {
        rb.AddForce(Vector2.right * forwardSpeed);
    }

    void review() { }

    void isHit(Collision2D collision)
    {
        if (godMode == 1)
            return;
        if (collision.gameObject.name == "Hat")
            return;
        if (collision.gameObject.tag == "Pik" && hp != 0)
        {
            hp -= 1;
            return;
        }
        animator.SetTrigger("Death");
        dead = true; ;
    }
}