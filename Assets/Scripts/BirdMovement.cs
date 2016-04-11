using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {

    Animator animator;
    Rigidbody2D rb;
    public float flapSpeed = 100f;
	public float forwardSpeed = 1f;
    public bool IsPause = false;
	public bool IsGuiClick = false;
    public bool godMode = false;
    public bool dead = false;
    bool didFlap = false;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = transform.GetComponentInChildren<Animator>();
        IsPause = true;
        Time.timeScale = 0;
		if(animator == null) {
			Debug.LogError("Didn't find animator!");
		}
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
		if(godMode) return;	
		animator.SetTrigger("Death");
		dead = true;
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
}
