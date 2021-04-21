using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecolectable : MonoBehaviour
{
    public Puntuacion puntuacion;
    public GameObject[] armas;
        
    void Start()
	{
		puntuacion = GameObject.FindGameObjectWithTag("Player").GetComponent<Puntuacion>();
	}
    
    private void OnTriggerEnter(Collider col){
    	if (this.tag == "Weapon")
    	{
        	if(col.tag == "Player"){
            	col.GetComponent<ThirdPersonController>().ObtenerArma(armas[0]);

        	}
    	} else
		{
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
