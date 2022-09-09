using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastingEnem : MonoBehaviour
{
    public AudioSource _audSour;

    public GameObject canion1;

    public int range = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectarEnemigo();
    }

    void DetectarEnemigo(){
        RaycastHit hit;

        if(Physics.Raycast(canion1.transform.position,canion1.transform.forward,out hit,range)){
            if(hit.transform.tag == "Jugador"){
                _audSour.Play();
            }
        }
    }
}
