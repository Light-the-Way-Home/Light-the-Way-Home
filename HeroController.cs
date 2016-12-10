using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour
{

	public float maxSpeed = 8f;
	private bool facingRight = true;

	public Transform groundCheck;
	private float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;

	private bool grounded = false;
	private Rigidbody2D rb2d;
	private Animator anim;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}


	void FixedUpdate ()
	{

		//grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));
		anim.SetBool ("Ground", grounded);

		anim.SetFloat ("vSpeed", rb2d.velocity.y);

		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		rb2d.velocity = new Vector2 (move * maxSpeed, rb2d.velocity.y);

		if (move > 0 && !facingRight) {
			Flip ();
		} else if (move < 0 && facingRight) {
			Flip ();
		}
	}

	void Update ()
	{
		if (grounded && Input.GetButtonDown ("Jump")) {
			anim.SetBool ("Ground", false);
			rb2d.AddForce (new Vector2 (0, jumpForce));
		}

	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
