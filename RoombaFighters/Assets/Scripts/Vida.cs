using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public float vida = 100;
    public GameObject RoombaRota;
    public GameObject RoombaMuerta;
    public Image barraDeVida;

    // Update is called once per frame
    void Update()
    {
	vida = Mathf.Clamp(vida,0,100);

	barraDeVida.fillAmount = vida / 100;
	if (vida == 0)
	{
		RoombaMuerta = GameObject.Find("Roomba");
		Debug.Log(RoombaMuerta.transform.position);
	    Instantiate(RoombaRota, RoombaMuerta.transform.position, Quaternion.identity);
	    Destroy(this.gameObject);
	    Debug.Log("GAME OVER");
	}
        
    }
}
