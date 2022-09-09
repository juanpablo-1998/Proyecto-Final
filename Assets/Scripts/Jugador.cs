
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Jugador : MonoBehaviour
{
    public Animator porfa;

    public float speed = 0.00005f;

    public GameObject gameOver, colliderEspada;
    
    void Start()
    {
        DesactivarEspada();
    }


    void FixedUpdate()
    {
        if(porfa.GetBool("isDead") == false){
        Mover();
        Atacar();
        }

    }



    void Mover(){

        float ver = 0;
        ver = Input.GetAxis("Vertical");
        float hor = 0;
        hor = Input.GetAxis("Horizontal");

        if(ver != 0 || hor != 0){

        porfa.SetBool("running",true);

        transform.Translate(new Vector3(hor/5,0,ver/5) * speed);
        }
        else
        {

            porfa.SetBool("running",false);
        }
    }

    void Atacar(){

        if(Input.GetMouseButtonDown(0)){

            colliderEspada.SetActive(true);
            porfa.SetBool("ataqueSoft",true);
            Invoke("DesactivarEspada",3);
             

        }else{

            porfa.SetBool("ataqueSoft",false);

        }

        if(Input.GetMouseButtonDown(1)){

            colliderEspada.SetActive(true); 
            porfa.SetBool("ataqueHard",true);
            Invoke("DesactivarEspada",3);

        }else{

            porfa.SetBool("ataqueHard",false);
        }
    }


     private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemigo"){
            PlayerManager.unicaInstanciaVida.vidaJugador -= 4;
        }

        if(other.gameObject.tag == "PuertaSalida"){
            SceneManager.LoadScene(2);
        }

        if(other.gameObject.tag == "PuertaCastillo"){
            SceneManager.LoadScene(3);
        }

        if(other.gameObject.tag == "Pocion"){
            PlayerManager.unicaInstanciaVida.vidaJugador += 50;
            
        }

         if(other.gameObject.tag == "Boss"){
            PlayerManager.unicaInstanciaVida.vidaJugador -= 7;
        }
    }

    public void GameOver(){

        porfa.SetBool("isDead",true);
        gameOver.SetActive(true);
        Invoke("ReiniciarJuego",5);
        
     }

     public void ReiniciarJuego(){
        SceneManager.LoadScene(1);
        PlayerManager.unicaInstanciaVida.vidaJugador = 100;
        porfa.SetBool("isDead",false);
        gameOver.SetActive(false);

     }

    public void DesactivarEspada(){
        colliderEspada.SetActive(false);
    }

}
