using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector1J : MonoBehaviour
{

    public int tiempoMinutos;

    public float tiempoRestante;

    public Text panelTemporizador;    

    public TrashContainer contenedorJugador1;
    
    public TrashContainer contenedorJugador2;

    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = 60 * OpcionesJuego.GetInstance().tiempoMinutos;
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempoRestante < 0){
            //Terminar nivel
            if(contenedorJugador1.trashLevel > contenedorJugador2.trashLevel)
                Debug.Log("FIN Ganador: Jugador 1");
            else if (contenedorJugador1.trashLevel < contenedorJugador2.trashLevel)
                Debug.Log("FIN Ganador: Jugador 2");
            else 
                Debug.Log("FIN Empate");
            SceneManager.LoadScene("Victory");
        }else{
            int minutos, segundos;
            minutos = Mathf.FloorToInt(tiempoRestante / 60);
            segundos = Mathf.FloorToInt(tiempoRestante % 60);

            panelTemporizador.text = minutos.ToString("00") + ":" + segundos.ToString("00");
            tiempoRestante -= Time.deltaTime;
        }


    }
}
