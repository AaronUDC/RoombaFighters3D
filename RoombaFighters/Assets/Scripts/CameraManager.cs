using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;


public class CameraManager : MonoBehaviour
{
    private InputMaster inputSystem;
    private Vector2 LookCamera; // your LookDelta
    public float deadZoneX = 0.2f;
 
    private void Awake()
    {
        inputSystem = new InputMaster();
 
        inputSystem.Jugador.ControlCamara.performed += ctx => LookCamera = ctx.ReadValue<Vector2>().normalized;
        inputSystem.Jugador.ControlCamara.performed += ctx => GetInput();
    }
 
    private void GetInput()
    {
        CinemachineCore.GetInputAxis = GetAxisCustom;
    }
 
    public float GetAxisCustom(string axisName)
    {
        // LookCamera.Normalize();
 
        if (axisName == "Mouse X")
        {
          if (LookCamera.x > deadZoneX || LookCamera.x < -deadZoneX) // To stabilise Cam and prevent it from rotating when LookCamera.x value is between deadZoneX and - deadZoneX
           {
             return LookCamera.x;
           }
        }
 
        else if (axisName == "Mouse Y")
        {
            return LookCamera.y;
        }
 
        return 0;
    }
 
    private void OnEnable()
    {
        inputSystem.Jugador.Enable();
    }
 
    private void OnDisable()
    {
        inputSystem.Jugador.Disable();
    }
}
