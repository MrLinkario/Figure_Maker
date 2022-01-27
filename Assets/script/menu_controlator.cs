using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_controlator : MonoBehaviour
{
    //carteles
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject menu4;
    public GameObject menu5;
    public GameObject menu6;
    public GameObject menu7;
    public GameObject menu8;
    public GameObject menu9;
    public GameObject menu10;
    public GameObject menu11;
    public GameObject menu12;
    public GameObject menu13;
    public GameObject menu14;
    public GameObject menu15;
    public GameObject menu16;
    public GameObject menu17;
    public GameObject menu18;
    public GameObject controles_jugador;
    public GameObject menu_pausa;
    public GameObject boton_pausa;

    public GameObject next1;
    public GameObject next2;
    public GameObject next3;
    public GameObject next4;
    public GameObject next5;
    public GameObject next6;
    public GameObject next7;
    public GameObject next8;
    public GameObject next9;

    public GameObject camara_principal;
    public GameObject camara_secundaria;
    public GameObject cartel_camara_secundaria;
    public GameObject gizmo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void menu1a2()
    {
        menu1.SetActive(false);
        menu2.SetActive(true);
    }

    public void menu2a3()
    {
        menu2.SetActive(false);
        menu3.SetActive(true);
    }

    public void menu3a4()
    {
        menu3.SetActive(false);
        menu4.SetActive(true);
    }

    public void menu4a5()
    {
        menu4.SetActive(false);
        menu5.SetActive(true);
    }

    public void menu5a6()
    {
        menu5.SetActive(false);
        menu6.SetActive(true);
    }

    public void menu6a7()
    {
        menu6.SetActive(false);
        menu7.SetActive(true);
    }

    public void menu7a8()
    {
        menu7.SetActive(false);
        menu8.SetActive(true);
    }

    public void menu8a9()
    {
        menu8.SetActive(false);
        menu9.SetActive(true);
    }

    public void menu9a10()
    {
        menu9.SetActive(false);
        menu10.SetActive(true);
    }

    public void menu10a11()
    {
        menu10.SetActive(false);
        menu11.SetActive(true);
    }

    public void menu11a12()
    {
        menu11.SetActive(false);
        menu12.SetActive(true);
    }

    public void menu12a13()
    {
        menu12.SetActive(false);
        menu13.SetActive(true);
    }

    public void menu13a14()
    {
        menu13.SetActive(false);
        menu14.SetActive(true);
    }

    public void menu14a15()
    {
        menu14.SetActive(false);
        menu15.SetActive(true);
    }

    public void menu15a16()
    {
        menu15.SetActive(false);
        menu16.SetActive(true);
    }

    public void menu16a17()
    {
        menu16.SetActive(false);
        menu17.SetActive(true);
    }

    public void menu17a18()
    {
        menu17.SetActive(false);
        menu18.SetActive(true);
    }


    public void ajugar()
    {
        menu18.SetActive(false);
        controles_jugador.SetActive(true);
        camara_secundaria.SetActive(false);
        cartel_camara_secundaria.SetActive(false);
        gizmo.SetActive(false);
        camara_principal.SetActive(true);
        boton_pausa.SetActive(true);
    }

    public void menu2a1()
    {
        menu2.SetActive(false);
        menu1.SetActive(true);
    }

    public void menu3a2()
    {
        menu3.SetActive(false);
        menu2.SetActive(true);
    }

    public void menu4a3()
    {
        menu4.SetActive(false);
        menu3.SetActive(true);
    }

    public void menu5a4()
    {
        menu5.SetActive(false);
        menu4.SetActive(true);
    }

    public void menu6a5()
    {
        menu6.SetActive(false);
        menu5.SetActive(true);
    }

    public void menu7a6()
    {
        menu7.SetActive(false);
        menu6.SetActive(true);
    }

    public void menu8a7()
    {
        menu8.SetActive(false);
        menu7.SetActive(true);
    }

    public void menu9a8()
    {
        menu9.SetActive(false);
        menu8.SetActive(true);
    }

    public void menu10a9()
    {
        menu10.SetActive(false);
        menu9.SetActive(true);
    }

    public void menu11a10()
    {
        menu11.SetActive(false);
        menu10.SetActive(true);
    }

    public void menu12a11()
    {
        menu12.SetActive(false);
        menu11.SetActive(true);
    }

    public void menu13a12()
    {
        menu13.SetActive(false);
        menu12.SetActive(true);
    }

    public void menu14a13()
    {
        menu14.SetActive(false);
        menu13.SetActive(true);
    }

    public void menu15a14()
    {
        menu15.SetActive(false);
        menu14.SetActive(true);
    }

    public void menu16a15()
    {
        menu16.SetActive(false);
        menu15.SetActive(true);
    }

    public void menu17a16()
    {
        menu17.SetActive(false);
        menu16.SetActive(true);
    }

    public void menu18a17()
    {
        menu18.SetActive(false);
        menu17.SetActive(true);
    }


    public void volver_a_armar()
    {
        controles_jugador.SetActive(false);
        menu_pausa.SetActive(false);
        menu18.SetActive(true);
        camara_principal.SetActive(false);
        camara_secundaria.SetActive(true);
        cartel_camara_secundaria.SetActive(true);
        camara_secundaria.GetComponent<camara_extra>().desplazamiento = 0;
        camara_secundaria.GetComponent<camara_extra>().giro = 0;
        gizmo.SetActive(true);
    }

    public void activar_next1()
    {
        next1.SetActive(true);
    }

    public void activar_next2 ()
    {
        next2.SetActive(true);
    }

    public void activar_next3()
    {
        next3.SetActive(true);
    }

    public void activar_next4()
    {
        next4.SetActive(true);
    }

    public void activar_next5()
    {
        next5.SetActive(true);
    }

    public void activar_next6()
    {
        next6.SetActive(true);
    }

    public void activar_next7()
    {
        next7.SetActive(true);
    }

    public void activar_next8()
    {
        next8.SetActive(true);
    }

    public void activar_next9()
    {
        next9.SetActive(true);
    }

    public void activar_pausa()
    {
        controles_jugador.SetActive(false);
        menu_pausa.SetActive(true);
        boton_pausa.SetActive(false);
    }

    public void descativar_pausa()
    {
        controles_jugador.SetActive(true);
        menu_pausa.SetActive(false);
        boton_pausa.SetActive(true);
    }

}
