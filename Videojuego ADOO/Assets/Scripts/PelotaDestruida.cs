using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaDestruida : MonoBehaviour {

    private int balasMax = 0;
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Bala"))
            balasMax++;

        if (balasMax == 10)
        {
            anim.SetTrigger("PelotaDestruida");
            Invoke("DestruirPelota", 1);
            GameController.instance.AvionScore();
        }

    }
    private void DestruirPelota()
    {

        Destroy(gameObject);
    }
}
