using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterControl : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.left);
        }

        //Motion Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.right);
        }

        //Up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);
        }

        //Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);
        }

        //Space key for shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Creamos un nuevo gameobject Missile a partir de un prefab (planos de Construccion)
            GameObject newTeamrocket = GameObject.Instantiate(Resources.Load("Bullets/Teamrocket") as GameObject);

            //Buscamos el Pivote del disparo
            GameObject Shootpivot = GameObject.Find("FighterControl/Shootpivot");

            //Hacemos que el misil sea hijo de Shoot pivot
            NewMethod(newTeamrocket, Shootpivot);

            //Movemos el misil hacia donde esta el shoot pvot, es decir, debajo del ala
            newTeamrocket.transform.localPosition = Vector3.zero;

            //Hacemos que los misiles ya no sean hijos del avion
            newTeamrocket.transform.SetParent(null);
        }
    }

    private static void NewMethod(GameObject newTeamrocket, GameObject Shootpivot)
    {
        newTeamrocket.transform.SetParent(Shootpivot.transform);
    }
} //End Update