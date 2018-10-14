using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teamrocket : MonoBehaviour
{

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento hacia adelante
        this.transform.Translate(Vector3.forward * speed);
    }

    // End Update

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision dectectada");

        //Buscamos un gameobject llamado Enemy
        GameObject Rats = collision.collider.gameObject;

        //Eliminamos el gameobject encontrado
        GameObject.Destroy(Rats);

        //Eliminamos tambin el misil
        GameObject Teamrocket = this.gameObject;
        GameObject.Destroy(Teamrocket);
    }


}