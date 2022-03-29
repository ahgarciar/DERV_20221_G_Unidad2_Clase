using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBalas : MonoBehaviour
{
    [SerializeField]
    GameObject bala;

    [SerializeField]
    GameObject spawnBala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject temp = Instantiate(bala, 
                spawnBala.transform.position,
                spawnBala.transform.rotation);

            Destroy(temp,2);
        }
    }
}
