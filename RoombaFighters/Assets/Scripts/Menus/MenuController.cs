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
        if(pantallas != null && pantallas.Length > 0){
            if(screen < pantallas.Length){
                for(int i = 0; i<pantallas.Length; i++)
                    pantallas[i].SetActive(false);
            }

            pantallas[screen].SetActive(true);
        }
    }


    public void GotoLevel(string scene){
        SceneManager.LoadScene(scene);
    }

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void QuitGame(){
        Application.Quit(1);
    }
}

