using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefesRespawning : MonoBehaviour {
    public GameObject Dinosaurio;
    public int tiempoRespawn=80;
	// Use this for initialization
	void Start () {
        Invoke("RespawnDinosaurio", tiempoRespawn);//80
    }
	
	// Update is called once per frame
	void Update () {
       

    }
    private void RespawnDinosaurio()
    {
        Vector3 posicionDinosaurio = new Vector3(5.61f, -2.376648f,0);
        Instantiate(Dinosaurio, posicionDinosaurio, Quaternion.identity);
    }

}
        
     
