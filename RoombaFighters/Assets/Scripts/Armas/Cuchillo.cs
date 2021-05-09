using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuchillo : Arma
{
    public Vector2Int minMaxBasura;

    public Vector2Int minMaxVeces;

    public Animator animator;
    // Start is called before the first frame update
    protected override void Start(){
        base.Start();
        animator = gameObject.GetComponent<Animator>();
    }

    public override void Atacar(){
        if(atacable){
            animator.SetTrigger("Atacar");
            StartCoroutine("EsperarCoolDown");
        }
    }

    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player" && collider.gameObject != roomba){
            Debug.Log("Atacado");

            int veces = Mathf.RoundToInt(Random.Range(minMaxVeces.x,minMaxVeces.y));

            List<int> cuantities = new List<int>();

            for(int i = 0; i<veces;i++){
                cuantities.Add(Random.Range(minMaxBasura.x,minMaxBasura.y));
            }

            collider.gameObject.GetComponent<TrashContainer>().LooseTrash(cuantities);

        }
    }
}