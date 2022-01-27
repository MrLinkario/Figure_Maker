using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_principal : MonoBehaviour
{
    public GameObject menu_inicial;
    public GameObject boton_volver;

    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject D5;
    public GameObject D6;
    public GameObject D7;
    public GameObject D8;
    public GameObject D9;
    public GameObject D10;
    public GameObject D11;

    public GameObject I1;
    public GameObject I2;
    public GameObject I3;
    public GameObject I4;
    public GameObject I5;
    public GameObject I6;
    public GameObject I7;
    public GameObject I8;
    public GameObject I9;
    public GameObject I10;
    public GameObject I11;


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void volver_a_menu()
    {
        menu_inicial.SetActive(true);
        boton_volver.SetActive(false);

        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        D5.SetActive(false);
        D6.SetActive(false);
        D7.SetActive(false);
        D8.SetActive(false);
        D9.SetActive(false);
        D10.SetActive(false);
        D11.SetActive(false);

        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        I6.SetActive(false);
        I7.SetActive(false);
        I8.SetActive(false);
        I9.SetActive(false);
        I10.SetActive(false);
        I11.SetActive(false);
    }

    public void leer_diapositivas()
    {
        menu_inicial.SetActive(false);
        boton_volver.SetActive(true);

        D1.SetActive(true);
    }

    public void D1aD2()
    {
        D1.SetActive(false);
        D2.SetActive(true);
    }

    public void D2aD1()
    {
        D2.SetActive(false);
        D1.SetActive(true);
    }

    public void D2aD3()
    {
        D2.SetActive(false);
        D3.SetActive(true);
    }

    public void D3aD2()
    {
        D3.SetActive(false);
        D2.SetActive(true);
    }

    public void D3aD4()
    {
        D3.SetActive(false);
        D4.SetActive(true);
    }

    public void D4aD3()
    {
        D4.SetActive(false);
        D3.SetActive(true);
    }

    public void D4aD5()
    {
        D4.SetActive(false);
        D5.SetActive(true);
    }

    public void D5aD4()
    {
        D5.SetActive(false);
        D4.SetActive(true);
    }

    public void D5aD6()
    {
        D5.SetActive(false);
        D6.SetActive(true);
    }

    public void D6aD5()
    {
        D6.SetActive(false);
        D5.SetActive(true);
    }

    public void D6aD7()
    {
        D6.SetActive(false);
        D7.SetActive(true);
    }

    public void D7aD6()
    {
        D7.SetActive(false);
        D6.SetActive(true);
    }

    public void D7aD8()
    {
        D7.SetActive(false);
        D8.SetActive(true);
    }

    public void D8aD7()
    {
        D8.SetActive(false);
        D7.SetActive(true);
    }

    public void D8aD9()
    {
        D8.SetActive(false);
        D9.SetActive(true);
    }

    public void D9aD8()
    {
        D9.SetActive(false);
        D8.SetActive(true);
    }

    public void D9aD10()
    {
        D9.SetActive(false);
        D10.SetActive(true);
    }

    public void D10aD9()
    {
        D10.SetActive(false);
        D9.SetActive(true);
    }

    public void D10aD11()
    {
        D10.SetActive(false);
        D11.SetActive(true);
    }

    public void D11aD10()
    {
        D11.SetActive(false);
        D10.SetActive(true);
    }

    public void I1aI2()
    {
        I1.SetActive(false);
        I2.SetActive(true);
    }

    public void I2aI1()
    {
        I2.SetActive(false);
        I1.SetActive(true);
    }

    public void I2aI3()
    {
        I2.SetActive(false);
        I3.SetActive(true);
    }

    public void I3aI2()
    {
        I3.SetActive(false);
        I2.SetActive(true);
    }

    public void I3aI4()
    {
        I3.SetActive(false);
        I4.SetActive(true);
    }

    public void I4aI3()
    {
        I4.SetActive(false);
        I3.SetActive(true);
    }

    public void I4aI5()
    {
        I4.SetActive(false);
        I5.SetActive(true);
    }

    public void I5aI4()
    {
        I5.SetActive(false);
        I4.SetActive(true);
    }

    public void I5aI6()
    {
        I5.SetActive(false);
        I6.SetActive(true);
    }

    public void I6aI5()
    {
        I6.SetActive(false);
        I5.SetActive(true);
    }

    public void I6aI7()
    {
        I6.SetActive(false);
        I7.SetActive(true);
    }

    public void I7aI6()
    {
        I7.SetActive(false);
        I6.SetActive(true);
    }

    public void I7aI8()
    {
        I7.SetActive(false);
        I8.SetActive(true);
    }

    public void I8aI7()
    {
        I8.SetActive(false);
        I7.SetActive(true);
    }

    public void I8aI9()
    {
        I8.SetActive(false);
        I9.SetActive(true);
    }

    public void I9aI8()
    {
        I9.SetActive(false);
        I8.SetActive(true);
    }

    public void I9aI10()
    {
        I9.SetActive(false);
        I10.SetActive(true);
    }

    public void I10aI9()
    {
        I10.SetActive(false);
        I9.SetActive(true);
    }

    public void I10aI11()
    {
        I10.SetActive(false);
        I11.SetActive(true);
    }

    public void I11aI10()
    {
        I11.SetActive(false);
        I10.SetActive(true);
    }

    public void jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void leeinstrucciones()
    {
        menu_inicial.SetActive(false);
        boton_volver.SetActive(true);

        I1.SetActive(true);
    }

    public void salir_app()
    {
        Application.Quit();
    }







}
