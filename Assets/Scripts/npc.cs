using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    public GameObject presionaE, mensaje;

    public bool jugadorCerca = false; 


    void Update(){
        if(jugadorCerca){

            if(Input.GetKeyDown(KeyCode.E)){
                if(presionaE.activeInHierarchy){
                presionaE.SetActive(false);
                mensaje.SetActive(true);
                }else{
                presionaE.SetActive(true);
                mensaje.SetActive(false);
                }

            }
        }
    }


    private void OnCollisionEnter(Collision other) {
           if(other.gameObject.tag == "Jugador"){
            presionaE.SetActive(true);
            jugadorCerca = true;
        }
        
    }
         
    

    private void OnCollisionExit(Collision other) {

        presionaE.SetActive(false);
        mensaje.SetActive(false);
        jugadorCerca = false;
    }
}
