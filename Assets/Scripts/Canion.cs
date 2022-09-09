using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{
    public GameObject canion1,jugador;

    public int speed = 2;


    // Update is called once per frame
    void Update()
    {
        MirarJugador();

    }

    void MirarJugador(){

        Quaternion newRotation = Quaternion.LookRotation((jugador.transform.position - canion1.transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation,newRotation,speed * Time.deltaTime);
    }

}
