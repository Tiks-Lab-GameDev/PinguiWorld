using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb;
    public float flapSpeed = 100f;
	public float forwardSpeed = 1f;
    public bool IsGuiClick;
    Collider2D pikColl;
    GameObject pik;
    Main main;
    SaveScore ss;
    bool didFlap = false;
    


	// Use this for initialization
	void Start () {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        ss = GameObject.Find("Scripts").GetComponent<SaveScore>();
        IsGuiClick = false;
        rb = GetComponent<Rigidbody2D>();
        animator = transform.GetComponentInChildren<Animator>();
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
        if(main.Dead) return;
        move();
        if (didFlap) flap();
        rotation();

	}

	void OnCollisionEnter2D(Collision2D collision) {
        isHit(collision);
         // change on my method if dont work save(); on savescore.cs
    }

    void flap()
    {
        rb.AddForce(Vector2.up * flapSpeed);
        animator.SetTrigger("DoFlap");
        didFlap = false;
        GameObject.Find("Flap_sound").GetComponent<AudioSource>().Play();
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
        if(collision.gameObject.name == "Fish")
        {
            Destroy(GameObject.Find("Fish"));
            ss.AddFish();
            return;
        }
        if (main.Godmode == true)
            return;
        if (collision.gameObject.name == "Hat")
            return;
        if (collision.gameObject.tag == "Pik" && main.Hp != 0)
        {
            GameObject.Find("Hit_sounds").GetComponent<AudioSource>().Play();
            main.Hp -= 1;
            return;
        }
        animator.SetTrigger("Death");
        GameObject.Find("Die_sound").GetComponent<AudioSource>().Play();
        main.Dead = true;
        ss.Save();
    }
}