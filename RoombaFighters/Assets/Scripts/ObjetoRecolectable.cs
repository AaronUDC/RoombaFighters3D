using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecolectable : MonoBehaviour
{
    
    public GameObject[] armas;
    private void OnTriggerEnter(Collider col){
        if(col.tag == "Player"){
            col.GetComponent<ThirdPersonController>().ObtenerArma(armas[0]);

        }
        
        
    }

    private void OnTriggerExit(Collider col){
        if(col.tag == "Player"){
            Destroy(gameObject, 0.5f);
        }
        
        
    }
}
