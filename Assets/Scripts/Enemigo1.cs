using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
{   
    public GameObject jugador;

    public float speed = 3 ,speedToLook = 2;

    public Animator anim;

    public float distanJug = 0;
    public bool acercarseAlJugador;


   // public Collider selfCollider1,selfCollider2;
    

    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(anim.GetBool("isDead")){ 
            acercarseAlJugador = false;
            //Destroy(selfCollider1);
            //Destroy(selfCollider2);
        }else{
            ChequearDistanciaJugador();
            MirarJugador();
    
        }

        if(acercarseAlJugador){
            transform.position = Vector3.MoveTowards(transform.position,jugador.transform.position,speed * Time.deltaTime);
            
        }
    }


    void ChequearDistanciaJugador()
    {   

        distanJug = Vector3.Distance(transform.position,jugador.transform.position);

        if(distanJug >= 15){
            JugadorLejos();
        }else if(distanJug < 15 && distanJug > 1.4f){
            JugadorCerca();
        }else{
            JugadorAlLado();
        }
  
    }

    void JugadorLejos(){
        anim.SetBool("jugadorCerca",false);
        anim.SetBool("jugadorAlLado",false);
        acercarseAlJugador = false;
    }

    void JugadorCerca(){
        anim.SetBool("jugadorCerca",true);
        anim.SetBool("jugadorAlLado",false);
        acercarseAlJugador = true;
        
    }

    void JugadorAlLado(){
        anim.SetBool("jugadorCerca",false);
        anim.SetBool("jugadorAlLado",true);
        acercarseAlJugador = false;
    }

    void MirarJugador(){

    Quaternion newRotation = Quaternion.LookRotation((jugador.transform.position - transform.position));
    transform.rotation = Quaternion.Lerp(transform.rotation,newRotation,speedToLook * Time.deltaTime);

    }

}
