using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : PowerUp
{
    public Animator animator;
    // Start is called before the first frame update
    protected override void Start(){
        base.Start();
        animator = gameObject.GetComponent<Animator>();
    }
}