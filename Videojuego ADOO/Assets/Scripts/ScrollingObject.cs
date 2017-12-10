using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float velocidadScrolling=1.5f;
	// Use this for initialization
	private void Awake () {
        rb2d = GetComponent<Rigidbody2D>();
	}
    private void Start(){
        rb2d.velocity = Vector2.right * (velocidadScrolling)*(-1);
    }


}
