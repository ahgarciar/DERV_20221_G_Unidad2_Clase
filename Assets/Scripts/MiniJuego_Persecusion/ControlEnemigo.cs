using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    [SerializeField]
    public GameObject personajeJugador;

    Vector3 posInicio;

    // Start is called before the first frame update
    void Start()
    {
        posInicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (personajeJugador != null)
        { //sigue al personaje
            transform.LookAt(personajeJugador.transform);

            transform.position = Vector3.MoveTowards(
                transform.position,
                personajeJugador.transform.position,
                6f * Time.deltaTime);
        }
        else {  //regresa a posicion de inicio
            transform.LookAt(posInicio);

            transform.position = Vector3.MoveTowards(
                transform.position,
                posInicio,
                6f * Time.deltaTime);
        }

    }
}
