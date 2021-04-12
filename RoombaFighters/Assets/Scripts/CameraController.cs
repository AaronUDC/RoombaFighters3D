using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target,player;
    public float sensibilidad;
    public Vector2 giro;
    
    public Vector2 rotacion;
    

    // Update is called once per frame
    void LateUpdate()
    {
       CamControll();
    }

    void CamControll(){
        
        rotacion += giro;

        rotacion.y = Mathf.Clamp(rotacion.y, -35,60);

        transform.LookAt(target);

        target.rotation = Quaternion.Euler(rotacion.y,rotacion.x,0);

    }

}
