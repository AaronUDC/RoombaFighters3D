using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpcionesJuego
{
    public bool multijugador;
    public int tiempoMinutos;

    public float volumen;

    public int puntosJ1;
    
    public int puntosJ2;


    private static OpcionesJuego instancia;

    private OpcionesJuego(bool multijugador, int tiempoMinutos){
        this.multijugador = multijugador;
        this.tiempoMinutos = tiempoMinutos;
        this.volumen = 1;
        this.puntosJ1 = 0;
        this.puntosJ2 = 0;
    }
    public static OpcionesJuego GetInstance(){
        if(instancia == null){
            instancia = new OpcionesJuego(false, 5);
        }

        return instancia;
    }

    
}
