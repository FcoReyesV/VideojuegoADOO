using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour {
    public Sprite[] HeartSprites;
    public Image HeartUI;
    private Player player;
    private void Start(){
        player = GameObject.FindGameObjectWithTag("Avioneta").GetComponent<Player>();
    }

    private void Update()
    {
        //Debug.Log("Vidas desde script Hearsts: "+player.vidas);
        HeartUI.sprite = HeartSprites[player.vidas];
    }
}
