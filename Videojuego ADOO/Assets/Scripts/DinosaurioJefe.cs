using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurioJefe : MonoBehaviour {
    public int vidaDinosaurio = 200;
    private Rigidbody2D rb2d;
    public float timeJump = 6f;
    private float timeSinceLastJump;
    private float fuerzaSalto = 4.5f;
    public GameObject obstaculosJefe0;
    public GameObject obstaculosJefe1;
    public GameObject obstaculosJefe2;
    private Animator anim;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        InvokeRepeating("FireDinosaurio", 0.001f, 2f);
    }
   
	// Update is called once per frame
	void Update () {
        timeSinceLastJump += Time.deltaTime;
       
        if (timeSinceLastJump >= timeJump){
            rb2d.velocity = new Vector2(0f, fuerzaSalto);
            timeSinceLastJump = 0;
            
            
        }
        //CancelInvoke("FireDinosaurio");

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("vida dinosaurio " + vidaDinosaurio);
        if (collider.CompareTag("Bala"))
            vidaDinosaurio--;
        switch (vidaDinosaurio)
        {
            case 150:
                fuerzaSalto = 6f;
                timeJump = 3.5f;
                break;
            case 100:
                fuerzaSalto = 7f;
                timeJump = 3.5f;
                break;
            case 50:
                fuerzaSalto = 8.5f;
                timeJump = 3f;
                break;
            case 0:
                anim.SetTrigger("DinosaurioDied");
                Invoke("DestruirDinosaurio", 2);
                GameController.instance.NivelCompletado();
                break;
        }
        

    }

    private void FireDinosaurio(){
        int cubo_random = Random.Range(0, 3);
        GameObject cubo=null;
        switch (cubo_random)
        {
            case 0:
                cubo = obstaculosJefe0;
                break;
            case 1:
                cubo = obstaculosJefe1;
                break;
            case 2:
                cubo = obstaculosJefe2;
                break;
        }
        
        GameObject fighter = GameObject.FindGameObjectWithTag("JefeDinosaurio");
        if (fighter != null)
        {
            Vector3 posicionBloque = fighter.transform.position + Vector3.right * -3f ;
            Instantiate(cubo, posicionBloque, Quaternion.identity);
           

        }
    }
    private void DestruirDinosaurio()
    {

        Destroy(gameObject);
    }
}
