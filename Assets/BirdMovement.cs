using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public float flapSpeed = 100f;
	public float forwardSpeed = 1f;
	public bool IsPause = false;
	public bool IsGuiClick = false;
	bool didFlap = false;

	Animator animator;

		public bool dead = false;
	float deathCooldown;

	public bool godMode = false;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
        IsPause = true;
        Time.timeScale = 0;
		if(animator == null) {
			Debug.LogError("Didn't find animator!");
		}
	}

	// Do Graphic & Input updates here
	void Update() {

		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && !IsGuiClick ) {
				didFlap = true;
			}
		
	}

	
	// Do physics engine updates here
	void FixedUpdate () {

		if(dead)
			return;

		GetComponent<Rigidbody2D>().AddForce( Vector2.right * forwardSpeed );

		if(didFlap) {
			GetComponent<Rigidbody2D>().AddForce( Vector2.up * flapSpeed );
			animator.SetTrigger("DoFlap");


			didFlap = false;
		}

		if(GetComponent<Rigidbody2D>().velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {
			float angle = Mathf.Lerp (0, -90, (-GetComponent<Rigidbody2D>().velocity.y / 3f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(godMode)
			return;
				
		animator.SetTrigger("Death");
		dead = true;
		deathCooldown = 0.5f;
	}

}
