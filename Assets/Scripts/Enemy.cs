using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    bool chasingPlayer = false;
    public Transform player;
    public float speed = 15;
    public float pushForce = 10;
    Rigidbody rig;

    private Animator anim;
   


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
              // Si el enemigo te persiguiendo al jugador, que siempre vuelva a ver hacia el y se mueve hacia adelante
        if (chasingPlayer)
        {
            // Rota al enemigo para que vea hacia el jugador
            Vector3 posicionJugador = player.position;
            posicionJugador.y = transform.position.y;
            transform.LookAt(player.position); 
            // Mueve hacia el frente al enemigo
            rig.velocity = transform.forward * speed + new Vector3(0, rig.velocity.y, 0);
        }

         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            chasingPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            chasingPlayer = false;
        }
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("HasPerdido");
        }
    }

    public void FinalDeJuego()
    {
     
    }
    void Ganar()
    {
        SceneManager.LoadScene("Ganar");

    }
}

