using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlador_minijuego : MonoBehaviour
{
    //UIs
    public GameObject pantalla_registro;
    public GameObject pantalla_instrucciones;

    //jugador
    public GameObject carro;
    public GameObject controles;
    public GameObject boton_pausa;

    //obstaculos
    public GameObject conjunto_arcos;
    public GameObject arco1;
    public GameObject arco2;
    public GameObject arco3;
    public GameObject arco4;
    public GameObject arco5;
    public GameObject arco6;
    public GameObject arco7;
    public GameObject arco8;
    public GameObject arco9;
    public GameObject arco10;
    public GameObject arco11;
    public GameObject arco12;
    public GameObject arco13;
    public GameObject arco14;
    public GameObject arco15;
    public GameObject arco16;
    public GameObject arco17;
    public GameObject arco18;
    public GameObject arco19;
    public GameObject arco20;

    //zonas 
    public GameObject zona_inicio;
    public GameObject zona_registro;

    //pantalla de inicio de minijuego
    public GameObject pantalla_regresiva;
    public Text mostrar_cuenta_regresiva;
    float cuenta_regresiva;
    bool cuenta_trigger = false;

    //pantalla de minijuego
    public GameObject pantalla_minijuego;
    public Text mostrar_puntaje;
    public Text mostrar_tiempo;
    public float tiempo;
    public int puntaje;
    bool jugar = false;

    //panntallas de fin de juego
    public GameObject pantalla_final;
    public GameObject texto_derrota;
    public GameObject texto_ganar;
    public GameObject texto_perfect;
    public Text puntaje_final;
    public GameObject boton_terminar;
    public GameObject pantalla_despedida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //proceso cuenta regresiva para comenzar minijuego
        if (cuenta_trigger)
        {
            cuenta_regresiva -= Time.deltaTime;
            if (cuenta_regresiva > 1)
            {
                mostrar_cuenta_regresiva.text = cuenta_regresiva.ToString("f0");
            }
            else
            {
                if (cuenta_regresiva > 0)
                {
                    mostrar_cuenta_regresiva.text = "YA!";
                }
                else
                {
                    cuenta_trigger = false;
                    jugar = true;
                    controles.SetActive(true);
                    pantalla_regresiva.SetActive(false);
                    pantalla_minijuego.SetActive(true);
                   
                }
            }
        }
        //fin proceso cuenta regresiva para comenzar minijuego

        //proceso para controlar minijuego
        if (jugar)
        {
            mostrar_tiempo.text ="Tiempo: "+ tiempo.ToString("f0");
            mostrar_puntaje.text = "Puntaje: " + puntaje;
            tiempo -= Time.deltaTime;

            if (tiempo <= 0 || puntaje>=200)
            {
                jugar = false;
                finMinijuego();
            }
        }


        //fin proceso para controlar minijuego






    }

    public void resgistro_a_instruciones()
    {
        pantalla_registro.SetActive(false);
        pantalla_instrucciones.SetActive(true);
        controles.SetActive(false);
        boton_pausa.SetActive(false);
       
    }


    public void instrucciones_a_registro()
    {
        pantalla_instrucciones.SetActive(false);
        pantalla_registro.SetActive(true);
        controles.SetActive(true);
        boton_pausa.SetActive(true);
    }

    public void preparativos()
    {

        //colocar el auto en posición
        carro.transform.position = zona_inicio.transform.position;
        pantalla_instrucciones.SetActive(false);
        //controles.SetActive(true);

        //preparar los obstáculos
        arco1.SetActive(true);
        arco2.SetActive(true);
        arco3.SetActive(true);
        arco4.SetActive(true);
        arco5.SetActive(true);
        arco6.SetActive(true);
        arco7.SetActive(true);
        arco8.SetActive(true);
        arco9.SetActive(true);
        arco10.SetActive(true);
        arco11.SetActive(true);
        arco12.SetActive(true);
        arco13.SetActive(true);
        arco14.SetActive(true);
        arco15.SetActive(true);
        arco16.SetActive(true);
        arco17.SetActive(true);
        arco18.SetActive(true);
        arco19.SetActive(true);
        arco20.SetActive(true);
        conjunto_arcos.SetActive(true);

        zona_registro.SetActive(false);
        cuenta_regresiva = 4;
        tiempo = 100;
        puntaje = 0;
        cuenta_trigger = true;
        pantalla_regresiva.SetActive(true);

        texto_derrota.SetActive(false);
        texto_ganar.SetActive(false);
        texto_perfect.SetActive(false);
        boton_terminar.SetActive(false);


    }

    public void finMinijuego()
    {
        conjunto_arcos.SetActive(false);
        carro.GetComponent<conductor>().velocidad = 0;
        pantalla_minijuego.SetActive(false);
        controles.SetActive(false);
        pantalla_final.SetActive(true);
        puntaje_final.text = puntaje.ToString("f0");
        if (puntaje<160)
        {
            texto_derrota.SetActive(true);
        }
        else
        {
            boton_terminar.SetActive(true);
            if (puntaje >= 200)
            {
                texto_perfect.SetActive(true);
            }
            else
            {
                texto_ganar.SetActive(true);
            }
        }
    }

    public void reintentar()
    {
        pantalla_final.SetActive(false);
    }

    public void pantallaFinal_a_conducir()
    {
        pantalla_final.SetActive(false);
        controles.SetActive(true);
        zona_registro.SetActive(true);
        boton_pausa.SetActive(true);

    }

    public void pantallaFinal_a_terminarJuego()
    {
        pantalla_final.SetActive(false);
        pantalla_despedida.SetActive(true);
    }

    public void salirApp()
    {
        Application.Quit();
    }


}
