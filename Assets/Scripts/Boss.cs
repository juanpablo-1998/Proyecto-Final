using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    public static Boss unicaInstanciaBoss;

    void Awake()
    {
        if(Boss.unicaInstanciaBoss == null){
            Boss.unicaInstanciaBoss = this;
            DontDestroyOnLoad(gameObject); 
        }else{
            Destroy(gameObject);
        }
    }
    public GameObject jugador;

    public float speed = 3 ,speedToLook = 2;

    public Animator anim;

    public float distanJug = 0;
    public bool acercarseAlJugador;

    public float vidaBoss = 250;

    void Update()
    {
        if(vidaBoss <= 0 ){ 
            anim.SetBool("isDead",true);
            Destroy(gameObject,5);
            acercarseAlJugador = false;

        }else{
            ChequearDistanciaJugador();
            if(distanJug <= 15){
             //MirarJugador();
        }
           
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

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Espada"){
            vidaBoss -= 5;
        }
    }
}
