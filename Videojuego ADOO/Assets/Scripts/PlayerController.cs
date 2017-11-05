using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 10f;
	public float speed = 5f;
	//public bool grounded;

	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
		//anim.SetBool("Grounded", grounded);
	}

	void FixedUpdate(){

		//Con fixedVelocity disminuimos la velocidad de la caminata hasta 0, porque sino se quedaría caminando por siempre
		Vector3 fixedVelocity = rb2d.velocity;
		fixedVelocity.x *= 0.75f;
		rb2d.velocity = fixedVelocity;

		float h = Input.GetAxis("Horizontal");
		rb2d.AddForce(Vector2.right * speed * h);

		float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
		rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);
		//Cambia la dirección del sprite de izquierda a derecha y derecha a izquierda
		if (h > 0.1f) {
			transform.localScale = new Vector3(1f, 1f, 1f);
		} 

		if (h < -0.1f){
			transform.localScale = new Vector3(-1f, 1f, 1f);
		}

		Debug.Log(rb2d.velocity.x);
	}

}