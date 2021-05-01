using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecolectable : MonoBehaviour
{
    public Puntuacion puntuacion;
    public GameObject[] armas;

    private void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
            int arma = Random.Range(0, armas.Length - 1);
			col.GetComponent<ThirdPersonController>().ObtenerArma(armas[1]);
		}
    }

    private void OnTriggerExit(Collider col){
        if(col.tag == "Player"){
            Destroy(gameObject, 0.5f);
        }
        
        
    }
}
