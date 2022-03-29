using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionBala : MonoBehaviour
{
    [SerializeField]
    public float velocidad;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * velocidad, ForceMode.Impulse);
    }
}
