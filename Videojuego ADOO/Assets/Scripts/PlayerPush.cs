using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour {

	public float distance=1f;
	public LayerMask boxMask;
    GameObject box;
    // Use this for initialization
    private void Start () {
		
	}

    // Update is called once per frame

    private void Update () {
		Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, boxMask);
        //Comprobamos que se colisione con la caja, además de que tenga el tag y se presiona la letra E
        if (hit.collider != null && hit.collider.gameObject.tag == "Pushable" && Input.GetKeyDown(KeyCode.E))
        {
            box = hit.collider.gameObject;
            // Hacemos que la caja dependa del personaje para que se pueda mover. Para eso es FixedJoint2D
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<BoxPull>().estaEmpujado = true;
        }
        else if (Input.GetKeyUp(KeyCode.E)){
            //Desactivamos que la caja dependa del personaje cuando deje de presionar la E
            box.GetComponent<FixedJoint2D>().enabled = false;
            box.GetComponent<BoxPull>().estaEmpujado = false;
        }
    }
    private void OnDrawGizmos(){
        //Dibujamos una línea para saber la posicion de referencia
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);

    }
}
