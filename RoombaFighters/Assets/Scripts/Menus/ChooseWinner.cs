using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseWinner : MonoBehaviour
{
	public int jugador1;
	public int jugador2;
	public GameObject victory;
	public GameObject gameOver;
	public Text puntuacion1;
	public Text puntuacion2;
	
    // Start is called before the first frame update
    void Update()
    {
        jugador1 = OpcionesJuego.GetInstance().puntosJ1;
        jugador2 = OpcionesJuego.GetInstance().puntosJ2;
        puntuacion1.text = "" + jugador1;
        puntuacion2.text = "" + jugador2;
        if(jugador1 >= jugador2){
			victory.SetActive(true);
			gameOver.SetActive(false);
		} else {
			victory.SetActive(false);
			gameOver.SetActive(true);
		}
        
    }
}
