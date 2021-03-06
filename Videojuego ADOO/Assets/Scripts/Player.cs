﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Nuestro GameController está aquí
public class Player : MonoBehaviour {
    public static Player instance;
    public int vidas;
    private Animator anim;
    Collider2D colliderAvioneta;
    
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        colliderAvioneta = GetComponent<Collider2D>();
        vidas = 3;
    }
	
	// Update is called once per frame
	void Update () {
        if (vidas == 0){
            Destroy(gameObject);
            GameController.instance.AvionDie();
            Invoke("RegresarMenu", 3);
        }
    }
    public void OnTriggerEnter2D(Collider2D collider){
        if (collider.CompareTag("Obstaculo") || collider.CompareTag("ObstaculosJefe")){
            colliderAvioneta.enabled = false;
            anim.SetTrigger("Choco");
            vidas--;
            Invoke("Inmune", 3);
            
        }
    }

    private void Inmune(){
        anim.SetTrigger("Choco");
        colliderAvioneta.enabled = true;
    }

    private void RegresarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
