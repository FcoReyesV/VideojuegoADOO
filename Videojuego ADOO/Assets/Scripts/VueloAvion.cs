using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VueloAvion : MonoBehaviour {
    private Rigidbody2D rb2d;
   
    public float fuerzaAvion = 10f;
    public GameObject bala;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            rb2d.velocity = new Vector2(0f, 4.5f);
        }

       //Disparo de la bala
        if (Input.GetKeyDown(KeyCode.Space)){
            //Poner el repetidor en marcha
            InvokeRepeating("Fire", 0.001f, 0.25f);
            
        }
        else if (Input.GetKeyUp(KeyCode.Space)){
            //Detener el repetidor
            CancelInvoke("Fire");
        }


    }
    private void Fire(){
        GameObject fighter = GameObject.FindGameObjectWithTag("Avioneta");
        if (fighter != null){
            SoundSystem.instance.PlayFireSound();
            Vector3 posicionBala = fighter.transform.position + Vector3.right*1.5f + Vector3.down*(0.5f);
            Instantiate(bala, posicionBala, Quaternion.identity);
        }
    }
}
