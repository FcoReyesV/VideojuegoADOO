using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDisparo : MonoBehaviour {
    public float speedBullet= 1f;
	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(speedBullet,0);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 9.3 || transform.position.x <- 10.06)
            Destroy(gameObject);
	}
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Obstaculo") || collider.CompareTag("JefeDinosaurio") || collider.CompareTag("ObstaculosJefe"))
        {
            Destroy(gameObject);
        }
    }
}
