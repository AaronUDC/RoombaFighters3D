using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpcionesJuego
{
    public bool multijugador;
    public int tiempoMinutos;

    private static OpcionesJuego instancia;

    private OpcionesJuego(bool multijugador, int tiempoMinutos){
        this.multijugador = multijugador;
        this.tiempoMinutos = tiempoMinutos;
    }
    public static OpcionesJuego GetInstance(){
        if(instancia == null){
            instancia = new OpcionesJuego(false, 5);
        }

        return instancia;
    }

    
}
