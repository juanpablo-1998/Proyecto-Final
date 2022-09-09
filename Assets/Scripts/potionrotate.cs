using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionrotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,2,0));
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Jugador"){
            Destroy(gameObject);
        } 
    }
}
