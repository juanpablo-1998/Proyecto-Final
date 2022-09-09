using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int speed = 2;
    public float tiempoHastaDestruirse;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempoHastaDestruirse);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,0.2f) * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space)){
            transform.localScale *= 2;
        }
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
