using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public GameObject objAInstanciar;

    public GameObject canion;

    public float cadenciaDisparo = 0;
    float cadenciaAlmacenada;
    

    // Start is called before the first frame update
    void Start()
    {   cadenciaAlmacenada = cadenciaDisparo;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        DispararConCadencia();

    }

    void ReiniciarCadencia(){
         
        cadenciaDisparo = cadenciaAlmacenada;

    }

    void DispararConCadencia(){
       
        cadenciaDisparo -= Time.deltaTime;

        if(cadenciaDisparo < 0)
        {
        ReiniciarCadencia();
        Instantiate(objAInstanciar,transform.position,canion.transform.localRotation);
        
        }

    }

}
