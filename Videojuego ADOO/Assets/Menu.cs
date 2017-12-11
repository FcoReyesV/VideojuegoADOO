using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {
    public GameObject IniciarJ, Instrucciones, TextoInstruc, Regresar,Imagen1, Imagen2,PelotaImg;
    public void EmpezarJuego()
    {
        SceneManager.LoadScene("Level1");
    }
    public void InstruccionesJuego()
    {
        IniciarJ.SetActive(false);
        Instrucciones.SetActive(false);
        TextoInstruc.SetActive(true);
        Regresar.SetActive(true);
        Imagen1.SetActive(true);
        Imagen2.SetActive(true);
        PelotaImg.SetActive(true);
    }
    public void RegresarMenu()
    {
        IniciarJ.SetActive(true);
        Instrucciones.SetActive(true);
        TextoInstruc.SetActive(false);
        Regresar.SetActive(false);
        Imagen1.SetActive(false);
        Imagen2.SetActive(false);
        PelotaImg.SetActive(false);
    }
}
