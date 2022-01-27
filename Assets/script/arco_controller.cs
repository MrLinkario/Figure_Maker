using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arco_controller : MonoBehaviour
{
    public GameObject game_controler;
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
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            game_controler.GetComponent<controlador_minijuego>().puntaje += 10;
        }
    }

}
