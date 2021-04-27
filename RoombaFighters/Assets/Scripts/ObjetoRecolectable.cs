using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecolectable : MonoBehaviour
{
    public Puntuacion puntuacion;
    public Escudo escudo;
    public ThirdPersonController velocidad;
    public GameObject[] armas;
        
    void Start()
	{
		puntuacion = GameObject.FindGameObjectWithTag("Player").GetComponent<Puntuacion>();
		escudo = GameObject.FindGameObjectWithTag("Player").GetComponent<Escudo>();
		velocidad = GameObject.Find("Roomba").GetComponent<ThirdPersonController>();
	}
    
    private void OnTriggerEnter(Collider col){
    	if (this.tag == "Weapon")
    	{
        	if(col.tag == "Player"){
            	col.GetComponent<ThirdPersonController>().ObtenerArma(armas[0]);

        	}
    	} else if (this.tag == "PowerUp"){
    		if(this.name == "PowerUpS"){
				escudo.Invencible = true;
			} else if (this.name == "PowerUpV") {
				velocidad.powerUp = true;
			}
			Destroy(gameObject);
		} else {
			puntuacion.Valor = puntuacion.Valor + 1;
			Destroy(gameObject);
		}
        
    }

    private void OnTriggerExit(Collider col){
        if(col.tag == "Player"){
            Destroy(gameObject, 0.5f);
        }
        
        
    }
}
