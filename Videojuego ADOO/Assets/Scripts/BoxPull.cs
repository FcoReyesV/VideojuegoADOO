using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPull : MonoBehaviour {
    public bool estaEmpujado;
    private float xPos;
	// Use this for initialization
	void Start () {
        //Incializamos con la posición con la que se encuentra en el escenario
        xPos = transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {
        if (!estaEmpujado)
            transform.position = new Vector3(xPos, transform.position.y);
        else
            xPos = transform.position.x;
    }
}
