﻿using UnityEngine;
using System.Collections;

public class ControllerScripts : MonoBehaviour {
	public float maxSpeed=10;
	private bool facingRight=true;
	Animator anim;

	bool grounded=false;
	public Transform groundCheck;
	float groundRadius=0.2f;
	public LayerMask whatIsGround;
	public float jumpForce=700;
	bool doubleJump=false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {



		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		if (grounded)
						doubleJump = false;


		anim.SetFloat ("Vspeed", rigidbody2D.velocity.y);
		//if (!grounded)
						//return;

		  
		float move = 2f;//Input.GetAxis("Horizontal");
		anim.SetFloat("speed", Mathf.Abs (move));
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
		if (move > 0 && !facingRight) {
						Flip ();
				} else if (move < 0 && facingRight) {
						Flip ();
				}



	
	}

	void Update(){

		//if ((grounded || !doubleJump) && Input.GetKeyDown (KeyCode.Space)) {
			if ((grounded || !doubleJump) && Input.GetKeyDown(KeyCode.Mouse0)) {

			anim.SetBool ("Ground", false);
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
			if(!doubleJump && !grounded)
				doubleJump=true;


				}
				



		}


	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}
}
