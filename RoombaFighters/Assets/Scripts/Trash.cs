using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public int trashSize = 10;

    public Vector2Int randomSizeMinMax = new Vector2Int(10,50);
    private float logSize;
    public float lifeTime = 30;
    void Awake(){
        trashSize = Random.Range(randomSizeMinMax.x,randomSizeMinMax.y);
    }
    void Start()
    {      
        //Randomizar los tamaños y tiempos de desaparición
        lifeTime = Random.Range(20,40);

        Resize();
        Destroy(gameObject, lifeTime);
    }

    public void Resize(){
        logSize = Mathf.Log10(1+ trashSize);
        gameObject.transform.localScale = new Vector3(logSize, logSize, logSize);
    }


    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            //Debug.Log("ÑAM");
            col.gameObject.GetComponent<TrashContainer>().AddTrash(trashSize);
            Destroy(gameObject);
        }
    }
}
