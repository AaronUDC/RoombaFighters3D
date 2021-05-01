using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
    public Vector2Int minMaxBasura;

    public Vector2Int minMaxVeces;

    void OnTriggerEnter(Collider col){
        if(col.tag.Equals("Player")){
            TrashContainer container = col.GetComponent<TrashContainer>();

            int veces = Mathf.RoundToInt(Random.Range(minMaxVeces.x,minMaxVeces.y));

            List<int> cuantities = new List<int>();

            for(int i = 0; i<veces;i++){
                cuantities.Add(Random.Range(minMaxBasura.x,minMaxBasura.y));
            }

            container.LooseTrash(cuantities);
        }
    }
}
