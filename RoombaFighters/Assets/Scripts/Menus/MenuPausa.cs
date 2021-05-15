using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public static bool juegoEnPausa = false;

    public GameObject menuPausa;

    public bool getEstadoPausa(){
        return juegoEnPausa;
    }
    public void Pausar(){
        if (!juegoEnPausa){
            juegoEnPausa = true;
            menuPausa.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Reanudar(){

        if (juegoEnPausa){
            juegoEnPausa = false;
            menuPausa.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
