using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver;
    private int score = 0;
    public Text scoreText;
    // Use this for initialization
    public void Awake(){ //Creamos un singleton para que en la siguiente escena no se instancie de nuevo el jugador
        if (GameController.instance == null)
        {
            GameController.instance = this;
        }
        else if (GameController.instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController ha sido instanciado por segunda vez. No debería pasar");
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Level1");
        }

    }

    public void AvionScore(){
        if (gameOver) return;
        score++;
        scoreText.text = ""+score;
       // SoundSystem.instance.PlayCoinSound();
    }
    public void AvionDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;

    }
}
