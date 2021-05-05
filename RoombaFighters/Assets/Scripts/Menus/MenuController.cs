using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject[] pantallas;

    // Start is called before the first frame update
    void Start()
    {
           SetActiveScreen(0);
    }

    public void SetActiveScreen(int screen){
        if(screen < pantallas.Length){
            for(int i = 0; i<pantallas.Length; i++)
                pantallas[i].SetActive(false);
        }

        pantallas[screen].SetActive(true);
    }
}

