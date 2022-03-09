using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeteccionTriggers : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        string tag = other.gameObject.tag;

        Debug.Log("Entrando al trigger con: " + name + " de tag: " + tag);
      
        GameObject gameObject = other.gameObject;


    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Manteniendo el trigger con: " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Saliendo del trigger con: " + other.gameObject.name);
    }



}
