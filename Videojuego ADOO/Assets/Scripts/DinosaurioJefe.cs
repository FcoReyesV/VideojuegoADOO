using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurioJefe : MonoBehaviour {
    public int balasMax = 50;
    public GameObject objetoPadre;
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x == -98)
        {
            //Desactivamos el scroll del objeto padre
            objetoPadre.GetComponent<ScrollingObject>().enabled = false;
        }
	}

    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Balas " + balasMax);
        if (collider.CompareTag("Bala"))
            balasMax--;

        if (balasMax == 20)
        {
           // anim.SetTrigger("EstadoDinosaurio");
        }

    }
}
