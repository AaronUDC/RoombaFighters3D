using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : PowerUp
{

    public Animator animator;
    // Start is called before the first frame update
    protected override void Start(){
        base.Start();
    }

    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player" && collider.gameObject != roomba){
            Debug.Log("Protegido");
            collider.gameObject.GetComponent<TrashContainer>().isVulnerable = false;

        }
    }
}
