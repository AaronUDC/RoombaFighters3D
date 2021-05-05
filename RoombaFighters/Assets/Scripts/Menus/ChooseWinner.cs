using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseWinner : MonoBehaviour
{
	public int jugador;
	public int bot;
	public GameObject victory;
	public GameObject gameOver;
	public Text puntuacionJ;
	public Text puntuacionB;
	
    // Start is called before the first frame update
    void Start()
    {
        jugador = PlayerPrefs.GetInt("PuntuacionJ");
        bot = PlayerPrefs.GetInt("PuntuacionB");
        puntuacionJ.text = "" + jugador;
        puntuacionB.text = "" + bot;
        if(jugador >= bot){
            puntuacionJ.text = "" + jugador;
        	puntuacionB.text = "" + bot;
			victory.SetActive(true);
			gameOver.SetActive(false);
		} else {
			puntuacionJ.text = "" + bot;
        	puntuacionB.text = "" + jugador;
			victory.SetActive(false);
			gameOver.SetActive(true);
		}
        
    }

    // Update is called once per frame
    void Update()
    {
        jugador = PlayerPrefs.GetInt("PuntuacionJ");
        bot = PlayerPrefs.GetInt("PuntuacionB");
        if(jugador >= bot){
        	puntuacionJ.text = "" + jugador;
        	puntuacionB.text = "" + bot;
			victory.SetActive(true);
			gameOver.SetActive(false);
		} else {
		    puntuacionJ.text = "" + bot;
        	puntuacionB.text = "" + jugador;
			victory.SetActive(false);
			gameOver.SetActive(true);
		}
    }
}
