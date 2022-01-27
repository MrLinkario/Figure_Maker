using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zona_registro : MonoBehaviour
{

    public GameObject pantalla_registro;
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
        if (other.tag == "carro")
        {
            pantalla_registro.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "carro")
        {
            pantalla_registro.SetActive(false);

        }
    }
}
