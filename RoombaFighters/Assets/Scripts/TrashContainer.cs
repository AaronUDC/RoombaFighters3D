using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashContainer : MonoBehaviour
{
    public float trashLevel;

    public void AddTrash(float trashSize){
        trashLevel += trashSize;
    }
}
