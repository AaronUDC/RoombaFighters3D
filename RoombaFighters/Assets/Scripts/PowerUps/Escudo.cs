using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : PowerUp
{

    // Start is called before the first frame update
    protected override void Start(){
        base.Start();
        roomba.GetComponent<TrashContainer>().isVulnerable = false;
    }

    void Update(){
        
        roomba.GetComponent<TrashContainer>().isVulnerable = false;
    }

    public override void DestroyPowerUp(){
        
        roomba.GetComponent<TrashContainer>().isVulnerable = true;
        base.DestroyPowerUp();
    }
    

}
