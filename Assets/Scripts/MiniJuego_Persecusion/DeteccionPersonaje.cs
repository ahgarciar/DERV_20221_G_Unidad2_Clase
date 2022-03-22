using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionPersonaje : MonoBehaviour
{
    [SerializeField]
    GameObject Enemigo;
    ControlEnemigo controlEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        controlEnemigo = Enemigo.GetComponent<ControlEnemigo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;
        Debug.Log(tag);

        if (tag.Equals("Player")) {

            GameObject objDetectado =  other.gameObject;
            controlEnemigo.personajeJugador = objDetectado;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        string tag = other.tag;
        Debug.Log(tag);

        if (tag.Equals("Player"))
        {

            //GameObject objDetectado = other.gameObject;
            controlEnemigo.personajeJugador = null;

        }
    }


}
