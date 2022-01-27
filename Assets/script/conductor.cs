using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conductor : MonoBehaviour
{
    //public GameObject coche_armado1;
    //public GameObject coche_armado2;
    //public GameObject coche_armado3;
    public GameObject[] coches_armados;
    public GameObject[] coche_base;
    public float[] coche_base_valor;

    //variables bases
    public GameObject b4se_controlador;
    public int indice_base;
    public GameObject b4se;


    //variables llantas
    public GameObject[] llantas;
    public int indice_llanta1;
    public int indice_llanta2;
    public int indice_llanta3;
    public int indice_llanta4;
    public float[] llanta_giro;
    public float[] llanta_accel;

    //llanta1
    public GameObject neumatico1_controlador;
    public GameObject rueda1;
    //llanta2
    public GameObject neumatico2_controlador;
    public GameObject rueda2;
    //llanta3
    public GameObject neumatico3_controlador;
    public GameObject rueda3;
    //llanta 4
    public GameObject neumatico4_controlador;
    public GameObject rueda4;

    //variables placas
    public GameObject[] placas;
    public int indice_placa1;
    public int indice_placa2;
    public int indice_placa3;
    public int indice_placa4;

    //placa1
    public GameObject placa1_controlador;
    public GameObject plak1;
    //placa2
    public GameObject placa2_controlador;
    public GameObject plak2;
    //placa3
    public GameObject placa3_controlador;
    public GameObject plak3;
    //placa4
    public GameObject placa4_controlador;
    public GameObject plak4;

    //variables de movimiento
    public float velocidad;
    public float aceleracion;
    public float fuerza;
    public float velocidad_mayor;
    public float velocidad_reversa;
    public GameObject rigid;
    public float giro;
    public float valor_giro;
    public bool move_right;
    public bool move_left;

    //variables de transform, scale y rotate
    public float escala_basex;
    public float escala_basey;
    public float escala_basez;
    public float cambio_escala_base;
    public Text textoBase_escala;


    public float transform_rueda1x;
    public float transform_rueda1y;
    public float transform_rueda1z;
    public float escala_rueda1x;
    public float escala_rueda1y;
    public float escala_rueda1z;
    public float rotacion_rueda1x;
    public float rotacion_rueda1y;
    public float rotacion_rueda1z;
    public Text textoRueda1_transform;
    public Text textoRueda1_escala;
    public Text textoRueda1_rotate;


    public float transform_placa1x;
    public float transform_placa1y;
    public float transform_placa1z;
    public float escala_placa1x;
    public float escala_placa1y;
    public float escala_placa1z;
    public float rotacion_placa1x;
    public float rotacion_placa1y;
    public float rotacion_placa1z;
    public Text textoPlaca1_transform;
    public Text textoPlaca1_escala;
    public Text textoPlaca1_rotate;

    

    public float transform_rueda2x;
    public float transform_rueda2y;
    public float transform_rueda2z;
    public float escala_rueda2x;
    public float escala_rueda2y;
    public float escala_rueda2z;
    public float rotacion_rueda2x;
    public float rotacion_rueda2y;
    public float rotacion_rueda2z;
    public Text textoRueda2_transform;
    public Text textoRueda2_escala;
    public Text textoRueda2_rotate;


    public float transform_placa2x;
    public float transform_placa2y;
    public float transform_placa2z;
    public float escala_placa2x;
    public float escala_placa2y;
    public float escala_placa2z;
    public float rotacion_placa2x;
    public float rotacion_placa2y;
    public float rotacion_placa2z;
    public Text textoPlaca2_transform;
    public Text textoPlaca2_escala;
    public Text textoPlaca2_rotate;

    public float transform_rueda3x;
    public float transform_rueda3y;
    public float transform_rueda3z;
    public float escala_rueda3x;
    public float escala_rueda3y;
    public float escala_rueda3z;
    public float rotacion_rueda3x;
    public float rotacion_rueda3y;
    public float rotacion_rueda3z;
    public Text textoRueda3_transform;
    public Text textoRueda3_escala;
    public Text textoRueda3_rotate;


    public float transform_placa3x;
    public float transform_placa3y;
    public float transform_placa3z;
    public float escala_placa3x;
    public float escala_placa3y;
    public float escala_placa3z;
    public float rotacion_placa3x;
    public float rotacion_placa3y;
    public float rotacion_placa3z;
    public Text textoPlaca3_transform;
    public Text textoPlaca3_escala;
    public Text textoPlaca3_rotate;

    public float transform_rueda4x;
    public float transform_rueda4y;
    public float transform_rueda4z;
    public float escala_rueda4x;
    public float escala_rueda4y;
    public float escala_rueda4z;
    public float rotacion_rueda4x;
    public float rotacion_rueda4y;
    public float rotacion_rueda4z;
    public Text textoRueda4_transform;
    public Text textoRueda4_escala;
    public Text textoRueda4_rotate;


    public float transform_placa4x;
    public float transform_placa4y;
    public float transform_placa4z;
    public float escala_placa4x;
    public float escala_placa4y;
    public float escala_placa4z;
    public float rotacion_placa4x;
    public float rotacion_placa4y;
    public float rotacion_placa4z;
    public Text textoPlaca4_transform;
    public Text textoPlaca4_escala;
    public Text textoPlaca4_rotate;

    //variables que definen cuánto se modifican las variables d elas ruedas y placas
    public float cambio_transform_rueda1;
    public float cambio_escala_rueda1;
    public float cambio_rotacion_rueda1;

    public float cambio_transform_placa1;
    public float cambio_escala_placa1;
    public float cambio_rotacion_placa1;

    //zona de inicio de juego
    public GameObject zona_inicio;

    // Start is called before the first frame update
    void Start()
    {
        indice_base = 0;
        velocidad = 0;
        velocidad_mayor = 15.0f;
        velocidad_reversa = -5.0f;
        giro = 0.0f;
        move_right = false;
        move_left = false;
        valor_giro = 0;



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        this.transform.Translate(velocidad * Time.deltaTime, 0.0f, 0.0f);
        this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y + giro, this.transform.rotation.z);

        neumatico1_controlador.transform.Rotate(new Vector3(0f,0f,- velocidad*100) * Time.deltaTime);
        neumatico2_controlador.transform.Rotate(new Vector3(0f, 0f, -velocidad*100) * Time.deltaTime);
        neumatico3_controlador.transform.Rotate(new Vector3(0f, 0f, -velocidad*100) * Time.deltaTime);
        neumatico4_controlador.transform.Rotate(new Vector3(0f, 0f, -velocidad*100) * Time.deltaTime);

        boton_derecha();
        boton_izquierda();

        valor_giro = llanta_giro[indice_llanta1] + llanta_giro[indice_llanta2] + llanta_giro[indice_llanta3] + llanta_giro[indice_llanta4];
        aceleracion = llanta_accel[indice_llanta1] + llanta_accel[indice_llanta2] + llanta_accel[indice_llanta3] + llanta_accel[indice_llanta4];
        velocidad_mayor = coche_base_valor[indice_base];
        velocidad_reversa =-1* (velocidad_mayor / 3);

        //control de los textos de variables de los objetos

        //base
        textoBase_escala.text = "Scale    :" + escala_basex.ToString("f2") + "f " + escala_basey.ToString("f2") + "f " + escala_basez.ToString("f2") + "f ";

        //llanta1
        textoRueda1_transform.text = "Translate:" + transform_rueda1x.ToString("f2") + "f " + transform_rueda1y.ToString("f2") + "f " + transform_rueda1z.ToString("f2") + "f ";
        textoRueda1_escala.text = "Scale    :" + escala_rueda1x.ToString("f2") + "f " + escala_rueda1y.ToString("f2") + "f " + escala_rueda1z.ToString("f2") + "f ";
        textoRueda1_rotate.text = "Rotate   :" + rotacion_rueda1x + "f " + rotacion_rueda1y + "f " + rotacion_rueda1z + "f ";

        //placa 1
        textoPlaca1_transform.text = "Translate:" + transform_placa1x.ToString("f2") + "f " + transform_placa1y.ToString("f2") + "f " + transform_placa1z.ToString("f2") + "f ";
        textoPlaca1_escala.text = "Scale    :" + escala_placa1x.ToString("f2") + "f " + escala_placa1y.ToString("f2") + "f " + escala_placa1z.ToString("f2") + "f ";
        textoPlaca1_rotate.text = "Rotate   :" + rotacion_placa1x + "f " + rotacion_placa1y + "f " + rotacion_placa1z + "f ";

        //llanta2
        textoRueda2_transform.text = "Translate:" + transform_rueda2x.ToString("f2") + "f " + transform_rueda2y.ToString("f2") + "f " + transform_rueda2z.ToString("f2") + "f ";
        textoRueda2_escala.text = "Scale    :" + escala_rueda2x.ToString("f2") + "f " + escala_rueda2y.ToString("f2") + "f " + escala_rueda2z.ToString("f2") + "f ";
        textoRueda2_rotate.text = "Rotate   :" + rotacion_rueda2x + "f " + rotacion_rueda2y + "f " + rotacion_rueda2z + "f ";

        //placa 2
        textoPlaca2_transform.text = "Translate:" + transform_placa2x.ToString("f2") + "f " + transform_placa2y.ToString("f2") + "f " + transform_placa2z.ToString("f2") + "f ";
        textoPlaca2_escala.text = "Scale    :" + escala_placa2x.ToString("f2") + "f " + escala_placa2y.ToString("f2") + "f " + escala_placa2z.ToString("f2") + "f ";
        textoPlaca2_rotate.text = "Rotate   :" + rotacion_placa2x + "f " + rotacion_placa2y + "f " + rotacion_placa2z + "f ";

        //llanta3
        textoRueda3_transform.text = "Translate:" + transform_rueda3x.ToString("f2") + "f " + transform_rueda3y.ToString("f2") + "f " + transform_rueda3z.ToString("f2") + "f ";
        textoRueda3_escala.text = "Scale    :" + escala_rueda3x.ToString("f2") + "f " + escala_rueda3y.ToString("f2") + "f " + escala_rueda3z.ToString("f2") + "f ";
        textoRueda3_rotate.text = "Rotate   :" + rotacion_rueda3x + "f " + rotacion_rueda3y + "f " + rotacion_rueda3z + "f ";

        //placa 3
        textoPlaca3_transform.text = "Translate:" + transform_placa3x.ToString("f2") + "f " + transform_placa3y.ToString("f2") + "f " + transform_placa3z.ToString("f2") + "f ";
        textoPlaca3_escala.text = "Scale    :" + escala_placa3x.ToString("f2") + "f " + escala_placa3y.ToString("f2") + "f " + escala_placa3z.ToString("f2") + "f ";
        textoPlaca3_rotate.text = "Rotate   :" + rotacion_placa3x + "f " + rotacion_placa3y + "f " + rotacion_placa3z + "f ";

        //llanta4
        textoRueda4_transform.text = "Translate:" + transform_rueda4x.ToString("f2") + "f " + transform_rueda4y.ToString("f2") + "f " + transform_rueda4z.ToString("f2") + "f ";
        textoRueda4_escala.text = "Scale    :" + escala_rueda4x.ToString("f2") + "f " + escala_rueda4y.ToString("f2") + "f " + escala_rueda4z.ToString("f2") + "f ";
        textoRueda4_rotate.text = "Rotate   :" + rotacion_rueda4x + "f " + rotacion_rueda4y + "f " + rotacion_rueda4z + "f ";

        //placa 4
        textoPlaca4_transform.text = "Translate:" + transform_placa4x.ToString("f2") + "f " + transform_placa4y.ToString("f2") + "f " + transform_placa4z.ToString("f2") + "f ";
        textoPlaca4_escala.text = "Scale    :" + escala_placa4x.ToString("f2") + "f " + escala_placa4y.ToString("f2") + "f " + escala_placa4z.ToString("f2") + "f ";
        textoPlaca4_rotate.text = "Rotate   :" + rotacion_placa4x + "f " + rotacion_placa4y + "f " + rotacion_placa4z + "f ";



        //Inputs de pruebas
        if (Input.GetKeyDown(KeyCode.T))
        {
            acelerar();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            estabilizar();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            reversa();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            girar_izquierda();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            girar_derercha();
        }



        if (Input.GetKeyDown(KeyCode.A))
        {
            poner_base0();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            poner_base1();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            poner_base2();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            poner_rueda1_0();
            poner_rueda2_0();
            poner_rueda3_0();
            poner_rueda4_0();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            poner_rueda1_1();
            poner_rueda2_1();
            poner_rueda3_1();
            poner_rueda4_1();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            poner_rueda1_2();
            poner_rueda2_2();
            poner_rueda3_2();
            poner_rueda4_2();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            poner_placa1_0();
            poner_placa2_0();
            poner_placa3_0();
            poner_placa4_0();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            poner_placa1_1();
            poner_placa2_1();
            poner_placa3_1();
            poner_placa4_1();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            poner_placa1_2();
            poner_placa2_2();
            poner_placa3_2();
            poner_placa4_2();
        }




    }


    //controladores de movimiento
    //para que el coche frene
    public void estabilizar()
    {
        velocidad = 0;
    }

    //para acelerar el coche
    public void acelerar()
    {
        if (velocidad <= velocidad_mayor)
        {
            velocidad += aceleracion;
        }
        if(velocidad>velocidad_mayor)
        {
            velocidad = velocidad_mayor;
        }
       
        //fuerza = 1 * velocidad;
    }

    public void reversa()
    {
        if (velocidad >= velocidad_reversa)
        {
            velocidad -= aceleracion;
        }
        if(velocidad<velocidad_reversa)
        {
            velocidad = velocidad_reversa;
        }
        //fuerza = -1 * velocidad;
    }

    public void girar_izquierda()
    {
        if(velocidad != 0)
        {
            //this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y -10, this.transform.rotation.z);
            if (velocidad > 0)
                giro -= valor_giro;
            else
                giro += valor_giro;
        }
    }

    public void girar_derercha()
    {
        if (velocidad != 0)
        {
            //this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y + 10, this.transform.rotation.z);
            if (velocidad > 0)
                giro += valor_giro;
            else
                giro -= valor_giro;
        }
    }

    public void move_rightOn()
    {
        move_right = true;
    }
    public void move_rightOff()
    {
        move_right = false;
    }

    public void boton_derecha()
    {
        if (move_right)
        {
            if (velocidad != 0)
            {
                //this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y + 10, this.transform.rotation.z);
                if (velocidad > 0)
                    giro += valor_giro;
                else
                    giro -= valor_giro;


            }
        }
    }


    public void move_lefttOn()
    {
        move_left = true;
    }
    public void move_leftOff()
    {
        move_left = false;
    }

    public void boton_izquierda()
    {
        if (move_left)
        {
            if (velocidad != 0)
            {
                //this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y + 10, this.transform.rotation.z);
                if (velocidad > 0)
                    giro -= valor_giro;
                else
                    giro += valor_giro;


            }
        }
    }



    //colocar base de coche
    public void poner_base0()
    {
        indice_base = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(b4se);
        b4se = Instantiate(coche_base[indice_base], transform.position, Quaternion.identity);
        b4se.transform.SetParent(b4se_controlador.transform);
        b4se.transform.localScale = (new Vector3(escala_basex, escala_basey, escala_basez));
        b4se.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

    }

    public void poner_base1()
    {
        indice_base = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(b4se);
        b4se = Instantiate(coche_base[indice_base], transform.position, Quaternion.identity);
        b4se.transform.SetParent(b4se_controlador.transform);
        b4se.transform.localScale = (new Vector3(escala_basex, escala_basey, escala_basez));
        b4se.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }

    public void poner_base2()
    {
        indice_base = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(b4se);
        b4se = Instantiate(coche_base[indice_base], transform.position, Quaternion.identity);
        b4se.transform.SetParent(b4se_controlador.transform);
        b4se.transform.localScale = (new Vector3(escala_basex, escala_basey, escala_basez));
        b4se.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }


    //colocar llantas
    //colocar llanta 1

    public void poner_rueda1_0()
    {
        indice_llanta1 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda1);
        rueda1 = Instantiate(llantas[indice_llanta1], transform.position, Quaternion.identity);
        rueda1.transform.SetParent(neumatico1_controlador.transform);
        rueda1.transform.position = neumatico1_controlador.transform.position;
        rueda1.transform.localScale = (new Vector3(escala_rueda1x, escala_rueda1y, escala_rueda1z));
        rueda1.transform.rotation = Quaternion.Euler(rotacion_rueda1x, rotacion_rueda1y, rotacion_rueda1z);

    }

    public void poner_rueda1_1()
    {
        indice_llanta1 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda1);
        rueda1 = Instantiate(llantas[indice_llanta1], transform.position, Quaternion.identity);
        rueda1.transform.SetParent(neumatico1_controlador.transform);
        rueda1.transform.position = neumatico1_controlador.transform.position;
        rueda1.transform.localScale = (new Vector3(escala_rueda1x, escala_rueda1y, escala_rueda1z));
        rueda1.transform.rotation = Quaternion.Euler(rotacion_rueda1x, rotacion_rueda1y, rotacion_rueda1z);
    }

    public void poner_rueda1_2()
    {
        indice_llanta1 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda1);
        rueda1 = Instantiate(llantas[indice_llanta1], transform.position, Quaternion.identity);
        rueda1.transform.SetParent(neumatico1_controlador.transform);
        rueda1.transform.position = neumatico1_controlador.transform.position;
        rueda1.transform.localScale = (new Vector3(escala_rueda1x, escala_rueda1y, escala_rueda1z));
        rueda1.transform.rotation = Quaternion.Euler(rotacion_rueda1x, rotacion_rueda1y, rotacion_rueda1z);
    }


    //colocar llanta 2

    public void poner_rueda2_0()
    {
        indice_llanta2 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda2);
        rueda2 = Instantiate(llantas[indice_llanta2], transform.position, Quaternion.identity);
        rueda2.transform.SetParent(neumatico2_controlador.transform);
        rueda2.transform.position = neumatico2_controlador.transform.position;
        rueda2.transform.localScale = (new Vector3(escala_rueda2x, escala_rueda2y, escala_rueda2z));
        rueda2.transform.rotation = Quaternion.Euler(rotacion_rueda2x, rotacion_rueda2y, rotacion_rueda2z);

    }

    public void poner_rueda2_1()
    {
        indice_llanta2 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda2);
        rueda2 = Instantiate(llantas[indice_llanta2], transform.position, Quaternion.identity);
        rueda2.transform.SetParent(neumatico2_controlador.transform);
        rueda2.transform.position = neumatico2_controlador.transform.position;
        rueda2.transform.localScale = (new Vector3(escala_rueda2x, escala_rueda2y, escala_rueda2z));
        rueda2.transform.rotation = Quaternion.Euler(rotacion_rueda2x, rotacion_rueda2y, rotacion_rueda2z);
    }

    public void poner_rueda2_2()
    {
        indice_llanta2 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda2);
        rueda2 = Instantiate(llantas[indice_llanta2], transform.position, Quaternion.identity);
        rueda2.transform.SetParent(neumatico2_controlador.transform);
        rueda2.transform.position = neumatico2_controlador.transform.position;
        rueda2.transform.localScale = (new Vector3(escala_rueda2x, escala_rueda2y, escala_rueda2z));
        rueda2.transform.rotation = Quaternion.Euler(rotacion_rueda2x, rotacion_rueda2y, rotacion_rueda2z);
    }

    //llanta 3
    public void poner_rueda3_0()
    {
        indice_llanta3 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda3);
        rueda3 = Instantiate(llantas[indice_llanta3], transform.position, Quaternion.identity);
        rueda3.transform.SetParent(neumatico3_controlador.transform);
        rueda3.transform.position = neumatico3_controlador.transform.position;
        rueda3.transform.localScale = (new Vector3(escala_rueda3x, escala_rueda3y, escala_rueda3z));
        rueda3.transform.rotation = Quaternion.Euler(rotacion_rueda3x, rotacion_rueda3y, rotacion_rueda3z);

    }

    public void poner_rueda3_1()
    {
        indice_llanta3 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda3);
        rueda3 = Instantiate(llantas[indice_llanta3], transform.position, Quaternion.identity);
        rueda3.transform.SetParent(neumatico3_controlador.transform);
        rueda3.transform.position = neumatico3_controlador.transform.position;
        rueda3.transform.localScale = (new Vector3(escala_rueda3x, escala_rueda3y, escala_rueda3z));
        rueda3.transform.rotation = Quaternion.Euler(rotacion_rueda3x, rotacion_rueda3y, rotacion_rueda3z);

    }

    public void poner_rueda3_2()
    {
        indice_llanta3 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda3);
        rueda3 = Instantiate(llantas[indice_llanta3], transform.position, Quaternion.identity);
        rueda3.transform.SetParent(neumatico3_controlador.transform);
        rueda3.transform.position = neumatico3_controlador.transform.position;
        rueda3.transform.localScale = (new Vector3(escala_rueda3x, escala_rueda3y, escala_rueda3z));
        rueda3.transform.rotation = Quaternion.Euler(rotacion_rueda3x, rotacion_rueda3y, rotacion_rueda3z);

    }

    //llanta 4
    public void poner_rueda4_0()
    {
        indice_llanta4 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda4);
        rueda4 = Instantiate(llantas[indice_llanta4], transform.position, Quaternion.identity);
        rueda4.transform.SetParent(neumatico4_controlador.transform);
        rueda4.transform.position = neumatico4_controlador.transform.position;
        rueda4.transform.localScale = (new Vector3(escala_rueda4x, escala_rueda4y, escala_rueda4z));
        rueda4.transform.rotation = Quaternion.Euler(rotacion_rueda4x, rotacion_rueda4y, rotacion_rueda4z);

    }

    public void poner_rueda4_1()
    {
        indice_llanta4 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda4);
        rueda4 = Instantiate(llantas[indice_llanta4], transform.position, Quaternion.identity);
        rueda4.transform.SetParent(neumatico4_controlador.transform);
        rueda4.transform.position = neumatico4_controlador.transform.position;
        rueda4.transform.localScale = (new Vector3(escala_rueda4x, escala_rueda4y, escala_rueda4z));
        rueda4.transform.rotation = Quaternion.Euler(rotacion_rueda4x, rotacion_rueda4y, rotacion_rueda4z);

    }

    public void poner_rueda4_2()
    {
        indice_llanta4 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(rueda4);
        rueda4 = Instantiate(llantas[indice_llanta4], transform.position, Quaternion.identity);
        rueda4.transform.SetParent(neumatico4_controlador.transform);
        rueda4.transform.position = neumatico4_controlador.transform.position;
        rueda4.transform.localScale = (new Vector3(escala_rueda4x, escala_rueda4y, escala_rueda4z));
        rueda4.transform.rotation = Quaternion.Euler(rotacion_rueda4x, rotacion_rueda4y, rotacion_rueda4z);

    }

    //colocar placas
    //placa1
    public void poner_placa1_0()
    {
        indice_placa1 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak1);
        plak1 = Instantiate(placas[indice_placa1], transform.position, Quaternion.identity);
        plak1.transform.SetParent(placa1_controlador.transform);
        plak1.transform.position = placa1_controlador.transform.position;
        plak1.transform.localScale = (new Vector3(escala_placa1x, escala_placa1y, escala_placa1z));
        plak1.transform.rotation = Quaternion.Euler(rotacion_placa1x, rotacion_placa1y, rotacion_placa1z);

    }

    public void poner_placa1_1()
    {
        indice_placa1 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak1);
        plak1 = Instantiate(placas[indice_placa1], transform.position, Quaternion.identity);
        plak1.transform.SetParent(placa1_controlador.transform);
        plak1.transform.position = placa1_controlador.transform.position;
        plak1.transform.localScale = (new Vector3(escala_placa1x, escala_placa1y, escala_placa1z));
        plak1.transform.rotation = Quaternion.Euler(rotacion_placa1x, rotacion_placa1y, rotacion_placa1z);

    }

    public void poner_placa1_2()
    {
        indice_placa1 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak1);
        plak1 = Instantiate(placas[indice_placa1], transform.position, Quaternion.identity);
        plak1.transform.SetParent(placa1_controlador.transform);
        plak1.transform.position = placa1_controlador.transform.position;
        plak1.transform.localScale = (new Vector3(escala_placa1x, escala_placa1y, escala_placa1z));
        plak1.transform.rotation = Quaternion.Euler(rotacion_placa1x, rotacion_placa1y, rotacion_placa1z);

    }

    //placa2
    public void poner_placa2_0()
    {
        indice_placa2 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak2);
        plak2 = Instantiate(placas[indice_placa2], transform.position, Quaternion.identity);
        plak2.transform.SetParent(placa2_controlador.transform);
        plak2.transform.position = placa2_controlador.transform.position;
        plak2.transform.localScale = (new Vector3(escala_placa2x, escala_placa2y, escala_placa2z));
        plak2.transform.rotation = Quaternion.Euler(rotacion_placa2x, rotacion_placa2y, rotacion_placa2z);

    }

    public void poner_placa2_1()
    {
        indice_placa2 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak2);
        plak2 = Instantiate(placas[indice_placa2], transform.position, Quaternion.identity);
        plak2.transform.SetParent(placa2_controlador.transform);
        plak2.transform.position = placa2_controlador.transform.position;
        plak2.transform.localScale = (new Vector3(escala_placa2x, escala_placa2y, escala_placa2z));
        plak2.transform.rotation = Quaternion.Euler(rotacion_placa2x, rotacion_placa2y, rotacion_placa2z);

    }

    public void poner_placa2_2()
    {
        indice_placa2 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak2);
        plak2 = Instantiate(placas[indice_placa2], transform.position, Quaternion.identity);
        plak2.transform.SetParent(placa2_controlador.transform);
        plak2.transform.position = placa2_controlador.transform.position;
        plak2.transform.localScale = (new Vector3(escala_placa2x, escala_placa2y, escala_placa2z));
        plak2.transform.rotation = Quaternion.Euler(rotacion_placa2x, rotacion_placa2y, rotacion_placa2z);

    }

    //placa3
    public void poner_placa3_0()
    {
        indice_placa3 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak3);
        plak3 = Instantiate(placas[indice_placa3], transform.position, Quaternion.identity);
        plak3.transform.SetParent(placa3_controlador.transform);
        plak3.transform.position = placa3_controlador.transform.position;
        plak3.transform.localScale = (new Vector3(escala_placa3x, escala_placa3y, escala_placa3z));
        plak3.transform.rotation = Quaternion.Euler(rotacion_placa3x, rotacion_placa3y, rotacion_placa3z);

    }

    public void poner_placa3_1()
    {
        indice_placa3 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak3);
        plak3 = Instantiate(placas[indice_placa3], transform.position, Quaternion.identity);
        plak3.transform.SetParent(placa3_controlador.transform);
        plak3.transform.position = placa3_controlador.transform.position;
        plak3.transform.localScale = (new Vector3(escala_placa3x, escala_placa3y, escala_placa3z));
        plak3.transform.rotation = Quaternion.Euler(rotacion_placa3x, rotacion_placa3y, rotacion_placa3z);

    }

    public void poner_placa3_2()
    {
        indice_placa3 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak3);
        plak3 = Instantiate(placas[indice_placa3], transform.position, Quaternion.identity);
        plak3.transform.SetParent(placa3_controlador.transform);
        plak3.transform.position = placa3_controlador.transform.position;
        plak3.transform.localScale = (new Vector3(escala_placa3x, escala_placa3y, escala_placa3z));
        plak3.transform.rotation = Quaternion.Euler(rotacion_placa3x, rotacion_placa3y, rotacion_placa3z);

    }

    //placa 4
    public void poner_placa4_0()
    {
        indice_placa4 = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak4);
        plak4 = Instantiate(placas[indice_placa4], transform.position, Quaternion.identity);
        plak4.transform.SetParent(placa4_controlador.transform);
        plak4.transform.position = placa4_controlador.transform.position;
        plak4.transform.localScale = (new Vector3(escala_placa4x, escala_placa4y, escala_placa4z));
        plak4.transform.rotation = Quaternion.Euler(rotacion_placa4x, rotacion_placa4y, rotacion_placa4z);

    }

    public void poner_placa4_1()
    {
        indice_placa4 = 1;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak4);
        plak4 = Instantiate(placas[indice_placa4], transform.position, Quaternion.identity);
        plak4.transform.SetParent(placa4_controlador.transform);
        plak4.transform.position = placa4_controlador.transform.position;
        plak4.transform.localScale = (new Vector3(escala_placa4x, escala_placa4y, escala_placa4z));
        plak4.transform.rotation = Quaternion.Euler(rotacion_placa4x, rotacion_placa4y, rotacion_placa4z);

    }

    public void poner_placa4_2()
    {
        indice_placa4 = 2;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        GameObject.Destroy(plak4);
        plak4 = Instantiate(placas[indice_placa4], transform.position, Quaternion.identity);
        plak4.transform.SetParent(placa4_controlador.transform);
        plak4.transform.position = placa4_controlador.transform.position;
        plak4.transform.localScale = (new Vector3(escala_placa4x, escala_placa4y, escala_placa4z));
        plak4.transform.rotation = Quaternion.Euler(rotacion_placa4x, rotacion_placa4y, rotacion_placa4z);

    }

    //modificar variables de: base

        //scale
    public void aumento_base_escala_x() {
        b4se.transform.localScale = (new Vector3(b4se.transform.localScale.x+cambio_escala_base, b4se.transform.localScale.y, b4se.transform.localScale.z));
        escala_basex = escala_basex + cambio_escala_base;
    }

    public void disminución_base_escala_x()
    {
        b4se.transform.localScale = (new Vector3(b4se.transform.localScale.x - cambio_escala_base, b4se.transform.localScale.y, b4se.transform.localScale.z));
        escala_basex = escala_basex - cambio_escala_base;
    }

    public void aumento_base_escala_y()
    {
        b4se.transform.localScale = (new Vector3(b4se.transform.localScale.x , b4se.transform.localScale.y + cambio_escala_base, b4se.transform.localScale.z));
        escala_basey = escala_basey + cambio_escala_base;
    }

    public void disminución_base_escala_y()
    {
        b4se.transform.localScale = (new Vector3(b4se.transform.localScale.x, b4se.transform.localScale.y - cambio_escala_base, b4se.transform.localScale.z));
        escala_basey = escala_basey - cambio_escala_base;

    }

    public void aumento_base_escala_z()
    {
        b4se.transform.localScale = (new Vector3(b4se.transform.localScale.x, b4se.transform.localScale.y , b4se.transform.localScale.z + cambio_escala_base));
        escala_basez = escala_basez + cambio_escala_base;
    }

    public void disminución_base_escala_z()
    {
        b4se.transform.localScale = (new Vector3(b4se.transform.localScale.x, b4se.transform.localScale.y, b4se.transform.localScale.z - cambio_escala_base));
        escala_basez = escala_basez - cambio_escala_base;
    }

    //modificar variables de: LLanta 1
    //transform
    public void aumento_llanta1_transformx()
    {
        neumatico1_controlador.transform.localPosition = (new Vector3(neumatico1_controlador.transform.localPosition.x+cambio_transform_rueda1, neumatico1_controlador.transform.localPosition.y, neumatico1_controlador.transform.localPosition.z));
        transform_rueda1x = transform_rueda1x + cambio_transform_rueda1;
    }

    public void disminucion_llanta1_transformx()
    {
        neumatico1_controlador.transform.localPosition = (new Vector3(neumatico1_controlador.transform.localPosition.x - cambio_transform_rueda1, neumatico1_controlador.transform.localPosition.y, neumatico1_controlador.transform.localPosition.z));
        transform_rueda1x = transform_rueda1x - cambio_transform_rueda1;
    }

    public void aumento_llanta1_transformy()
    {
        neumatico1_controlador.transform.localPosition = (new Vector3(neumatico1_controlador.transform.localPosition.x , neumatico1_controlador.transform.localPosition.y + cambio_transform_rueda1, neumatico1_controlador.transform.localPosition.z));
        transform_rueda1y = transform_rueda1y + cambio_transform_rueda1;
    }

    public void disminucion_llanta1_transformy()
    {
        neumatico1_controlador.transform.localPosition = (new Vector3(neumatico1_controlador.transform.localPosition.x, neumatico1_controlador.transform.localPosition.y - cambio_transform_rueda1, neumatico1_controlador.transform.localPosition.z));
        transform_rueda1y = transform_rueda1y - cambio_transform_rueda1;
    }

    public void aumento_llanta1_transformz()
    {
        neumatico1_controlador.transform.localPosition = (new Vector3(neumatico1_controlador.transform.localPosition.x, neumatico1_controlador.transform.localPosition.y , neumatico1_controlador.transform.localPosition.z + cambio_transform_rueda1));
        transform_rueda1z = transform_rueda1z + cambio_transform_rueda1;
    }

    public void disminucion_llanta1_transformz()
    {
        neumatico1_controlador.transform.localPosition = (new Vector3(neumatico1_controlador.transform.localPosition.x, neumatico1_controlador.transform.localPosition.y, neumatico1_controlador.transform.localPosition.z - cambio_transform_rueda1));
        transform_rueda1z = transform_rueda1z - cambio_transform_rueda1;
    }

    //scale
    public void aumento_llanta1_scalex()
    {
        rueda1.transform.localScale = (new Vector3(rueda1.transform.localScale.x+cambio_escala_rueda1, rueda1.transform.localScale.y, rueda1.transform.localScale.z));
        escala_rueda1x = escala_rueda1x + cambio_escala_rueda1;
    }

    public void disminucion_llanta1_scalex()
    {
        rueda1.transform.localScale = (new Vector3(rueda1.transform.localScale.x - cambio_escala_rueda1, rueda1.transform.localScale.y, rueda1.transform.localScale.z));
        escala_rueda1x = escala_rueda1x - cambio_escala_rueda1;
    }

    public void aumento_llanta1_scaley()
    {
        rueda1.transform.localScale = (new Vector3(rueda1.transform.localScale.x , rueda1.transform.localScale.y + cambio_escala_rueda1, rueda1.transform.localScale.z));
        escala_rueda1y = escala_rueda1y + cambio_escala_rueda1;
    }

    public void disminucion_llanta1_scaley()
    {
        rueda1.transform.localScale = (new Vector3(rueda1.transform.localScale.x, rueda1.transform.localScale.y - cambio_escala_rueda1, rueda1.transform.localScale.z));
        escala_rueda1y = escala_rueda1y - cambio_escala_rueda1;
    }

    public void aumento_llanta1_scalez()
    {
        rueda1.transform.localScale = (new Vector3(rueda1.transform.localScale.x, rueda1.transform.localScale.y, rueda1.transform.localScale.z + cambio_escala_rueda1));
        escala_rueda1z = escala_rueda1z + cambio_escala_rueda1;
    }

    public void disminucion_llanta1_scalez()
    {
        rueda1.transform.localScale = (new Vector3(rueda1.transform.localScale.x, rueda1.transform.localScale.y, rueda1.transform.localScale.z - cambio_escala_rueda1));
        escala_rueda1z = escala_rueda1z - cambio_escala_rueda1;
    }

    //rotate
    public void aumento_llanta1_rotx()
    {
        rueda1.transform.Rotate(new Vector3(cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda1x = rotacion_rueda1x + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta1_rotx()
    {
        rueda1.transform.Rotate(new Vector3(- cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda1x = rotacion_rueda1x - cambio_rotacion_rueda1;
    }

    public void aumento_llanta1_roty()
    {
        rueda1.transform.Rotate(new Vector3(0f,cambio_rotacion_rueda1,0f));
        rotacion_rueda1y = rotacion_rueda1y + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta1_roty()
    {
        rueda1.transform.Rotate(new Vector3(0f, - cambio_rotacion_rueda1,0f));
        rotacion_rueda1y = rotacion_rueda1y - cambio_rotacion_rueda1;
    }

    public void aumento_llanta1_rotz()
    {
        rueda1.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_rueda1));
        rotacion_rueda1z = rotacion_rueda1z + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta1_rotz()
    {
        rueda1.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_rueda1));
        rotacion_rueda1z = rotacion_rueda1z - cambio_rotacion_rueda1;
    }

    //modificar variables de placa 1

    //transform
    public void aumento_placa1_transformx()
    {
        placa1_controlador.transform.localPosition = (new Vector3(placa1_controlador.transform.localPosition.x+cambio_transform_placa1, placa1_controlador.transform.localPosition.y, placa1_controlador.transform.localPosition.z));
        transform_placa1x = transform_placa1x + cambio_transform_placa1;
    }

    public void disminucion_placa1_transformx()
    {
        placa1_controlador.transform.localPosition = (new Vector3(placa1_controlador.transform.localPosition.x - cambio_transform_placa1, placa1_controlador.transform.localPosition.y, placa1_controlador.transform.localPosition.z));
        transform_placa1x = transform_placa1x - cambio_transform_placa1;
    }

    public void aumento_placa1_transformy()
    {
        placa1_controlador.transform.localPosition = (new Vector3(placa1_controlador.transform.localPosition.x , placa1_controlador.transform.localPosition.y + cambio_transform_placa1, placa1_controlador.transform.localPosition.z));
        transform_placa1y = transform_placa1y + cambio_transform_placa1;
    }

    public void disminucion_placa1_transformy()
    {
        placa1_controlador.transform.localPosition = (new Vector3(placa1_controlador.transform.localPosition.x, placa1_controlador.transform.localPosition.y - cambio_transform_placa1, placa1_controlador.transform.localPosition.z));
        transform_placa1y = transform_placa1y - cambio_transform_placa1;
    }

    public void aumento_placa1_transformz()
    {
        placa1_controlador.transform.localPosition = (new Vector3(placa1_controlador.transform.localPosition.x, placa1_controlador.transform.localPosition.y , placa1_controlador.transform.localPosition.z + cambio_transform_placa1));
        transform_placa1z = transform_placa1z + cambio_transform_placa1;
    }

    public void disminucion_placa1_transformz()
    {
        placa1_controlador.transform.localPosition = (new Vector3(placa1_controlador.transform.localPosition.x, placa1_controlador.transform.localPosition.y, placa1_controlador.transform.localPosition.z - cambio_transform_placa1));
        transform_placa1z = transform_placa1z - cambio_transform_placa1;
    }

    //scale

    public void aumento_placa1_scalex()
    {
        plak1.transform.localScale = (new Vector3(plak1.transform.localScale.x+ cambio_escala_placa1, plak1.transform.localScale.y, plak1.transform.localScale.z));
        escala_placa1x = escala_placa1x + cambio_escala_placa1;
    }

    public void disminucion_placa1_scalex()
    {
        plak1.transform.localScale = (new Vector3(plak1.transform.localScale.x - cambio_escala_placa1, plak1.transform.localScale.y, plak1.transform.localScale.z));
        escala_placa1x = escala_placa1x - cambio_escala_placa1;
    }

    public void aumento_placa1_scaley()
    {
        plak1.transform.localScale = (new Vector3(plak1.transform.localScale.x , plak1.transform.localScale.y + cambio_escala_placa1, plak1.transform.localScale.z));
        escala_placa1y = escala_placa1y + cambio_escala_placa1;
    }

    public void disminucion_placa1_scaley()
    {
        plak1.transform.localScale = (new Vector3(plak1.transform.localScale.x, plak1.transform.localScale.y - cambio_escala_placa1, plak1.transform.localScale.z));
        escala_placa1y = escala_placa1y - cambio_escala_placa1;
    }

    public void aumento_placa1_scalez()
    {
        plak1.transform.localScale = (new Vector3(plak1.transform.localScale.x, plak1.transform.localScale.y , plak1.transform.localScale.z + cambio_escala_placa1));
        escala_placa1z = escala_placa1z + cambio_escala_placa1;
    }

    public void disminucion_placa1_scalez()
    {
        plak1.transform.localScale = (new Vector3(plak1.transform.localScale.x, plak1.transform.localScale.y, plak1.transform.localScale.z - cambio_escala_placa1));
        escala_placa1z = escala_placa1z - cambio_escala_placa1;
    }

    //rotate

    public void aumento_placa1_rotx()
    {
        plak1.transform.Rotate(new Vector3(cambio_rotacion_placa1, 0f,0f));
        rotacion_placa1x = rotacion_placa1x + cambio_rotacion_placa1;
    }

    public void disminucion_placa1_rotx()
    {
        plak1.transform.Rotate(new Vector3(-cambio_rotacion_placa1, 0f, 0f));
        rotacion_placa1x = rotacion_placa1x - cambio_rotacion_placa1;
    }

    public void aumento_placa1_roty()
    {
        plak1.transform.Rotate(new Vector3(0f, cambio_rotacion_placa1, 0f));
        rotacion_placa1y = rotacion_placa1y + cambio_rotacion_placa1;
    }

    public void disminucion_placa1_roty()
    {
        plak1.transform.Rotate(new Vector3(0f, -cambio_rotacion_placa1, 0f));
        rotacion_placa1y = rotacion_placa1y - cambio_rotacion_placa1;
    }

    public void aumento_placa1_rotz()
    {
        plak1.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_placa1));
        rotacion_placa1z = rotacion_placa1z + cambio_rotacion_placa1;
    }

    public void disminucion_placa1_rotz()
    {
        plak1.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_placa1));
        rotacion_placa1z = rotacion_placa1z - cambio_rotacion_placa1;
    }

    //modificar variables de: LLanta 2
    //transform
    public void aumento_llanta2_transformx()
    {
        neumatico2_controlador.transform.localPosition = (new Vector3(neumatico2_controlador.transform.localPosition.x + cambio_transform_rueda1, neumatico2_controlador.transform.localPosition.y, neumatico2_controlador.transform.localPosition.z));
        transform_rueda2x = transform_rueda2x + cambio_transform_rueda1;
    }

    public void disminucion_llanta2_transformx()
    {
        neumatico2_controlador.transform.localPosition = (new Vector3(neumatico2_controlador.transform.localPosition.x - cambio_transform_rueda1, neumatico2_controlador.transform.localPosition.y, neumatico2_controlador.transform.localPosition.z));
        transform_rueda2x = transform_rueda2x - cambio_transform_rueda1;
    }

    public void aumento_llanta2_transformy()
    {
        neumatico2_controlador.transform.localPosition = (new Vector3(neumatico2_controlador.transform.localPosition.x, neumatico2_controlador.transform.localPosition.y + cambio_transform_rueda1, neumatico2_controlador.transform.localPosition.z));
        transform_rueda2y = transform_rueda2y + cambio_transform_rueda1;
    }

    public void disminucion_llanta2_transformy()
    {
        neumatico2_controlador.transform.localPosition = (new Vector3(neumatico2_controlador.transform.localPosition.x, neumatico2_controlador.transform.localPosition.y - cambio_transform_rueda1, neumatico2_controlador.transform.localPosition.z));
        transform_rueda2y = transform_rueda2y - cambio_transform_rueda1;
    }

    public void aumento_llanta2_transformz()
    {
        neumatico2_controlador.transform.localPosition = (new Vector3(neumatico2_controlador.transform.localPosition.x, neumatico2_controlador.transform.localPosition.y, neumatico2_controlador.transform.localPosition.z + cambio_transform_rueda1));
        transform_rueda2z = transform_rueda2z + cambio_transform_rueda1;
    }

    public void disminucion_llanta2_transformz()
    {
        neumatico2_controlador.transform.localPosition = (new Vector3(neumatico2_controlador.transform.localPosition.x, neumatico2_controlador.transform.localPosition.y, neumatico2_controlador.transform.localPosition.z - cambio_transform_rueda1));
        transform_rueda2z = transform_rueda2z - cambio_transform_rueda1;
    }

    //scale
    public void aumento_llanta2_scalex()
    {
        rueda2.transform.localScale = (new Vector3(rueda2.transform.localScale.x + cambio_escala_rueda1, rueda2.transform.localScale.y, rueda2.transform.localScale.z));
        escala_rueda2x = escala_rueda2x + cambio_escala_rueda1;
    }

    public void disminucion_llanta2_scalex()
    {
        rueda2.transform.localScale = (new Vector3(rueda2.transform.localScale.x - cambio_escala_rueda1, rueda2.transform.localScale.y, rueda2.transform.localScale.z));
        escala_rueda2x = escala_rueda2x - cambio_escala_rueda1;
    }

    public void aumento_llanta2_scaley()
    {
        rueda2.transform.localScale = (new Vector3(rueda2.transform.localScale.x, rueda2.transform.localScale.y + cambio_escala_rueda1, rueda2.transform.localScale.z));
        escala_rueda2y = escala_rueda2y + cambio_escala_rueda1;
    }

    public void disminucion_llanta2_scaley()
    {
        rueda2.transform.localScale = (new Vector3(rueda2.transform.localScale.x, rueda2.transform.localScale.y - cambio_escala_rueda1, rueda2.transform.localScale.z));
        escala_rueda2y = escala_rueda2y - cambio_escala_rueda1;
    }

    public void aumento_llanta2_scalez()
    {
        rueda2.transform.localScale = (new Vector3(rueda2.transform.localScale.x, rueda2.transform.localScale.y, rueda2.transform.localScale.z + cambio_escala_rueda1));
        escala_rueda2z = escala_rueda2z + cambio_escala_rueda1;
    }

    public void disminucion_llanta2_scalez()
    {
        rueda2.transform.localScale = (new Vector3(rueda2.transform.localScale.x, rueda2.transform.localScale.y, rueda2.transform.localScale.z - cambio_escala_rueda1));
        escala_rueda2z = escala_rueda2z - cambio_escala_rueda1;
    }

    //rotate
    public void aumento_llanta2_rotx()
    {
        rueda2.transform.Rotate(new Vector3(cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda2x = rotacion_rueda2x + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta2_rotx()
    {
        rueda2.transform.Rotate(new Vector3(-cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda2x = rotacion_rueda2x - cambio_rotacion_rueda1;
    }

    public void aumento_llanta2_roty()
    {
        rueda2.transform.Rotate(new Vector3(0f, cambio_rotacion_rueda1, 0f));
        rotacion_rueda2y = rotacion_rueda2y + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta2_roty()
    {
        rueda2.transform.Rotate(new Vector3(0f, -cambio_rotacion_rueda1, 0f));
        rotacion_rueda2y = rotacion_rueda2y - cambio_rotacion_rueda1;
    }

    public void aumento_llanta2_rotz()
    {
        rueda2.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_rueda1));
        rotacion_rueda2z = rotacion_rueda2z + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta2_rotz()
    {
        rueda2.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_rueda1));
        rotacion_rueda2z = rotacion_rueda2z - cambio_rotacion_rueda1;
    }

    //modificar variables de placa 2

    //transform
    public void aumento_placa2_transformx()
    {
        placa2_controlador.transform.localPosition = (new Vector3(placa2_controlador.transform.localPosition.x + cambio_transform_placa1, placa2_controlador.transform.localPosition.y, placa2_controlador.transform.localPosition.z));
        transform_placa2x = transform_placa2x + cambio_transform_placa1;
    }

    public void disminucion_placa2_transformx()
    {
        placa2_controlador.transform.localPosition = (new Vector3(placa2_controlador.transform.localPosition.x - cambio_transform_placa1, placa2_controlador.transform.localPosition.y, placa2_controlador.transform.localPosition.z));
        transform_placa2x = transform_placa2x - cambio_transform_placa1;
    }

    public void aumento_placa2_transformy()
    {
        placa2_controlador.transform.localPosition = (new Vector3(placa2_controlador.transform.localPosition.x, placa2_controlador.transform.localPosition.y + cambio_transform_placa1, placa2_controlador.transform.localPosition.z));
        transform_placa2y = transform_placa2y + cambio_transform_placa1;
    }

    public void disminucion_placa2_transformy()
    {
        placa2_controlador.transform.localPosition = (new Vector3(placa2_controlador.transform.localPosition.x, placa2_controlador.transform.localPosition.y - cambio_transform_placa1, placa2_controlador.transform.localPosition.z));
        transform_placa2y = transform_placa2y - cambio_transform_placa1;
    }

    public void aumento_placa2_transformz()
    {
        placa2_controlador.transform.localPosition = (new Vector3(placa2_controlador.transform.localPosition.x, placa2_controlador.transform.localPosition.y, placa2_controlador.transform.localPosition.z + cambio_transform_placa1));
        transform_placa2z = transform_placa2z + cambio_transform_placa1;
    }

    public void disminucion_placa2_transformz()
    {
        placa2_controlador.transform.localPosition = (new Vector3(placa2_controlador.transform.localPosition.x, placa2_controlador.transform.localPosition.y, placa2_controlador.transform.localPosition.z - cambio_transform_placa1));
        transform_placa2z = transform_placa2z - cambio_transform_placa1;
    }

    //scale

    public void aumento_placa2_scalex()
    {
        plak2.transform.localScale = (new Vector3(plak2.transform.localScale.x + cambio_escala_placa1, plak2.transform.localScale.y, plak2.transform.localScale.z));
        escala_placa2x = escala_placa2x + cambio_escala_placa1;
    }

    public void disminucion_placa2_scalex()
    {
        plak2.transform.localScale = (new Vector3(plak2.transform.localScale.x - cambio_escala_placa1, plak2.transform.localScale.y, plak2.transform.localScale.z));
        escala_placa2x = escala_placa2x - cambio_escala_placa1;
    }

    public void aumento_placa2_scaley()
    {
        plak2.transform.localScale = (new Vector3(plak2.transform.localScale.x, plak2.transform.localScale.y + cambio_escala_placa1, plak2.transform.localScale.z));
        escala_placa2y = escala_placa2y + cambio_escala_placa1;
    }

    public void disminucion_placa2_scaley()
    {
        plak2.transform.localScale = (new Vector3(plak2.transform.localScale.x, plak2.transform.localScale.y - cambio_escala_placa1, plak2.transform.localScale.z));
        escala_placa2y = escala_placa2y - cambio_escala_placa1;
    }

    public void aumento_placa2_scalez()
    {
        plak2.transform.localScale = (new Vector3(plak2.transform.localScale.x, plak2.transform.localScale.y, plak2.transform.localScale.z + cambio_escala_placa1));
        escala_placa2z = escala_placa2z + cambio_escala_placa1;
    }

    public void disminucion_placa2_scalez()
    {
        plak2.transform.localScale = (new Vector3(plak2.transform.localScale.x, plak2.transform.localScale.y, plak2.transform.localScale.z - cambio_escala_placa1));
        escala_placa2z = escala_placa2z - cambio_escala_placa1;
    }

    //rotate

    public void aumento_placa2_rotx()
    {
        plak2.transform.Rotate(new Vector3(cambio_rotacion_placa1, 0f, 0f));
        rotacion_placa2x = rotacion_placa2x + cambio_rotacion_placa1;
    }

    public void disminucion_placa2_rotx()
    {
        plak2.transform.Rotate(new Vector3(-cambio_rotacion_placa1, 0f, 0f));
        rotacion_placa2x = rotacion_placa2x - cambio_rotacion_placa1;
    }

    public void aumento_placa2_roty()
    {
        plak2.transform.Rotate(new Vector3(0f, cambio_rotacion_placa1, 0f));
        rotacion_placa2y = rotacion_placa2y + cambio_rotacion_placa1;
    }

    public void disminucion_placa2_roty()
    {
        plak2.transform.Rotate(new Vector3(0f, -cambio_rotacion_placa1, 0f));
        rotacion_placa2y = rotacion_placa2y - cambio_rotacion_placa1;
    }

    public void aumento_placa2_rotz()
    {
        plak2.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_placa1));
        rotacion_placa2z = rotacion_placa2z + cambio_rotacion_placa1;
    }

    public void disminucion_placa2_rotz()
    {
        plak2.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_placa1));
        rotacion_placa2z = rotacion_placa2z - cambio_rotacion_placa1;
    }

    //modificar variables de: LLanta 3
    //transform
    public void aumento_llanta3_transformx()
    {
        neumatico3_controlador.transform.localPosition = (new Vector3(neumatico3_controlador.transform.localPosition.x + cambio_transform_rueda1, neumatico3_controlador.transform.localPosition.y, neumatico3_controlador.transform.localPosition.z));
        transform_rueda3x=transform_rueda3x+cambio_transform_rueda1;
    }

    public void disminucion_llanta3_transformx()
    {
        neumatico3_controlador.transform.localPosition = (new Vector3(neumatico3_controlador.transform.localPosition.x - cambio_transform_rueda1, neumatico3_controlador.transform.localPosition.y, neumatico3_controlador.transform.localPosition.z));
        transform_rueda3x = transform_rueda3x - cambio_transform_rueda1;
    }

    public void aumento_llanta3_transformy()
    {
        neumatico3_controlador.transform.localPosition = (new Vector3(neumatico3_controlador.transform.localPosition.x, neumatico3_controlador.transform.localPosition.y + cambio_transform_rueda1, neumatico3_controlador.transform.localPosition.z));
        transform_rueda3y = transform_rueda3y + cambio_transform_rueda1;
    }

    public void disminucion_llanta3_transformy()
    {
        neumatico3_controlador.transform.localPosition = (new Vector3(neumatico3_controlador.transform.localPosition.x, neumatico3_controlador.transform.localPosition.y - cambio_transform_rueda1, neumatico3_controlador.transform.localPosition.z));
        transform_rueda3y = transform_rueda3y - cambio_transform_rueda1;
    }

    public void aumento_llanta3_transformz()
    {
        neumatico3_controlador.transform.localPosition = (new Vector3(neumatico3_controlador.transform.localPosition.x, neumatico3_controlador.transform.localPosition.y, neumatico3_controlador.transform.localPosition.z + cambio_transform_rueda1));
        transform_rueda3z = transform_rueda3z + cambio_transform_rueda1;
    }

    public void disminucion_llanta3_transformz()
    {
        neumatico3_controlador.transform.localPosition = (new Vector3(neumatico3_controlador.transform.localPosition.x, neumatico3_controlador.transform.localPosition.y, neumatico3_controlador.transform.localPosition.z - cambio_transform_rueda1));
        transform_rueda3z = transform_rueda3z - cambio_transform_rueda1;
    }

    //scale
    public void aumento_llanta3_scalex()
    {
        rueda3.transform.localScale = (new Vector3(rueda3.transform.localScale.x + cambio_escala_rueda1, rueda3.transform.localScale.y, rueda3.transform.localScale.z));
        escala_rueda3x = escala_rueda3x + cambio_escala_rueda1;
    }

    public void disminucion_llanta3_scalex()
    {
        rueda3.transform.localScale = (new Vector3(rueda3.transform.localScale.x - cambio_escala_rueda1, rueda3.transform.localScale.y, rueda3.transform.localScale.z));
        escala_rueda3x = escala_rueda3x - cambio_escala_rueda1;
    }

    public void aumento_llanta3_scaley()
    {
        rueda3.transform.localScale = (new Vector3(rueda3.transform.localScale.x, rueda3.transform.localScale.y + cambio_escala_rueda1, rueda3.transform.localScale.z));
        escala_rueda3y = escala_rueda3y + cambio_escala_rueda1;
    }

    public void disminucion_llanta3_scaley()
    {
        rueda3.transform.localScale = (new Vector3(rueda3.transform.localScale.x, rueda3.transform.localScale.y - cambio_escala_rueda1, rueda3.transform.localScale.z));
        escala_rueda3y = escala_rueda3y - cambio_escala_rueda1;
    }

    public void aumento_llanta3_scalez()
    {
        rueda3.transform.localScale = (new Vector3(rueda3.transform.localScale.x, rueda3.transform.localScale.y, rueda3.transform.localScale.z + cambio_escala_rueda1));
        escala_rueda3z = escala_rueda3z + cambio_escala_rueda1;
    }

    public void disminucion_llanta3_scalez()
    {
        rueda3.transform.localScale = (new Vector3(rueda3.transform.localScale.x, rueda3.transform.localScale.y, rueda3.transform.localScale.z - cambio_escala_rueda1));
        escala_rueda3z = escala_rueda3z - cambio_escala_rueda1;
    }

    //rotate
    public void aumento_llanta3_rotx()
    {
        rueda3.transform.Rotate(new Vector3(cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda3x = rotacion_rueda3x + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta3_rotx()
    {
        rueda3.transform.Rotate(new Vector3(-cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda3x = rotacion_rueda3x - cambio_rotacion_rueda1;
    }

    public void aumento_llanta3_roty()
    {
        rueda3.transform.Rotate(new Vector3(0f, cambio_rotacion_rueda1, 0f));
        rotacion_rueda3y = rotacion_rueda3y + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta3_roty()
    {
        rueda3.transform.Rotate(new Vector3(0f, -cambio_rotacion_rueda1, 0f));
        rotacion_rueda3y = rotacion_rueda3y - cambio_rotacion_rueda1;
    }

    public void aumento_llanta3_rotz()
    {
        rueda3.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_rueda1));
        rotacion_rueda3z = rotacion_rueda3z + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta3_rotz()
    {
        rueda3.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_rueda1));
        rotacion_rueda3z = rotacion_rueda3z - cambio_rotacion_rueda1;
    }

    //modificar variables de placa 3

    //transform
    public void aumento_placa3_transformx()
    {
        placa3_controlador.transform.localPosition = (new Vector3(placa3_controlador.transform.localPosition.x + cambio_transform_placa1, placa3_controlador.transform.localPosition.y, placa3_controlador.transform.localPosition.z));
        transform_placa3x = transform_placa3x + cambio_transform_placa1;
    }

    public void disminucion_placa3_transformx()
    {
        placa3_controlador.transform.localPosition = (new Vector3(placa3_controlador.transform.localPosition.x - cambio_transform_placa1, placa3_controlador.transform.localPosition.y, placa3_controlador.transform.localPosition.z));
        transform_placa3x = transform_placa3x - cambio_transform_placa1;
    }

    public void aumento_placa3_transformy()
    {
        placa3_controlador.transform.localPosition = (new Vector3(placa3_controlador.transform.localPosition.x, placa3_controlador.transform.localPosition.y + cambio_transform_placa1, placa3_controlador.transform.localPosition.z));
        transform_placa3y = transform_placa3y + cambio_transform_placa1;
    }

    public void disminucion_placa3_transformy()
    {
        placa3_controlador.transform.localPosition = (new Vector3(placa3_controlador.transform.localPosition.x, placa3_controlador.transform.localPosition.y - cambio_transform_placa1, placa3_controlador.transform.localPosition.z));
        transform_placa3y = transform_placa3y - cambio_transform_placa1;
    }

    public void aumento_placa3_transformz()
    {
        placa3_controlador.transform.localPosition = (new Vector3(placa3_controlador.transform.localPosition.x, placa3_controlador.transform.localPosition.y, placa3_controlador.transform.localPosition.z + cambio_transform_placa1));
        transform_placa3z = transform_placa3z + cambio_transform_placa1;
    }

    public void disminucion_placa3_transformz()
    {
        placa3_controlador.transform.localPosition = (new Vector3(placa3_controlador.transform.localPosition.x, placa3_controlador.transform.localPosition.y, placa3_controlador.transform.localPosition.z - cambio_transform_placa1));
        transform_placa3z = transform_placa3z - cambio_transform_placa1;
    }

    //scale

    public void aumento_placa3_scalex()
    {
        plak3.transform.localScale = (new Vector3(plak3.transform.localScale.x + cambio_escala_placa1, plak3.transform.localScale.y, plak3.transform.localScale.z));
        escala_placa3x = escala_placa3x + cambio_escala_placa1;
    }

    public void disminucion_placa3_scalex()
    {
        plak3.transform.localScale = (new Vector3(plak3.transform.localScale.x - cambio_escala_placa1, plak3.transform.localScale.y, plak3.transform.localScale.z));
        escala_placa3x = escala_placa3x - cambio_escala_placa1;
    }

    public void aumento_placa3_scaley()
    {
        plak3.transform.localScale = (new Vector3(plak3.transform.localScale.x, plak3.transform.localScale.y + cambio_escala_placa1, plak3.transform.localScale.z));
        escala_placa3y = escala_placa3y + cambio_escala_placa1;
    }

    public void disminucion_placa3_scaley()
    {
        plak3.transform.localScale = (new Vector3(plak3.transform.localScale.x, plak3.transform.localScale.y - cambio_escala_placa1, plak3.transform.localScale.z));
        escala_placa3y = escala_placa3y - cambio_escala_placa1;
    }

    public void aumento_placa3_scalez()
    {
        plak3.transform.localScale = (new Vector3(plak3.transform.localScale.x, plak3.transform.localScale.y, plak3.transform.localScale.z + cambio_escala_placa1));
        escala_placa3z = escala_placa3z + cambio_escala_placa1;
    }

    public void disminucion_placa3_scalez()
    {
        plak3.transform.localScale = (new Vector3(plak3.transform.localScale.x, plak3.transform.localScale.y, plak3.transform.localScale.z - cambio_escala_placa1));
        escala_placa3z = escala_placa3z - cambio_escala_placa1;
    }

    //rotate

    public void aumento_placa3_rotx()
    {
        plak3.transform.Rotate(new Vector3(cambio_rotacion_placa1, 0f, 0f));
        rotacion_placa3x = rotacion_placa3x + cambio_rotacion_placa1;
    }

    public void disminucion_placa3_rotx()
    {
        plak3.transform.Rotate(new Vector3(-cambio_rotacion_placa1, 0f, 0f));
        rotacion_placa3x = rotacion_placa3x - cambio_rotacion_placa1;
    }

    public void aumento_placa3_roty()
    {
        plak3.transform.Rotate(new Vector3(0f, cambio_rotacion_placa1, 0f));
        rotacion_placa3y = rotacion_placa3y + cambio_rotacion_placa1;
    }

    public void disminucion_placa3_roty()
    {
        plak3.transform.Rotate(new Vector3(0f, -cambio_rotacion_placa1, 0f));
        rotacion_placa3y = rotacion_placa3y - cambio_rotacion_placa1;
    }

    public void aumento_placa3_rotz()
    {
        plak3.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_placa1));
        rotacion_placa3z = rotacion_placa3z + cambio_rotacion_placa1;
    }

    public void disminucion_placa3_rotz()
    {
        plak3.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_placa1));
        rotacion_placa3z = rotacion_placa3z - cambio_rotacion_placa1;
    }

    //modificar variables de: LLanta 4
    //transform
    public void aumento_llanta4_transformx()
    {
        neumatico4_controlador.transform.localPosition = (new Vector3(neumatico4_controlador.transform.localPosition.x + cambio_transform_rueda1, neumatico4_controlador.transform.localPosition.y, neumatico4_controlador.transform.localPosition.z));
        transform_rueda4x = transform_rueda4x + cambio_transform_rueda1;
    }

    public void disminucion_llanta4_transformx()
    {
        neumatico4_controlador.transform.localPosition = (new Vector3(neumatico4_controlador.transform.localPosition.x - cambio_transform_rueda1, neumatico4_controlador.transform.localPosition.y, neumatico4_controlador.transform.localPosition.z));
        transform_rueda4x = transform_rueda4x - cambio_transform_rueda1;
    }

    public void aumento_llanta4_transformy()
    {
        neumatico4_controlador.transform.localPosition = (new Vector3(neumatico4_controlador.transform.localPosition.x, neumatico4_controlador.transform.localPosition.y + cambio_transform_rueda1, neumatico4_controlador.transform.localPosition.z));
        transform_rueda4y = transform_rueda4y + cambio_transform_rueda1;
    }

    public void disminucion_llanta4_transformy()
    {
        neumatico4_controlador.transform.localPosition = (new Vector3(neumatico4_controlador.transform.localPosition.x, neumatico4_controlador.transform.localPosition.y - cambio_transform_rueda1, neumatico4_controlador.transform.localPosition.z));
        transform_rueda4y = transform_rueda4y - cambio_transform_rueda1;
    }

    public void aumento_llanta4_transformz()
    {
        neumatico4_controlador.transform.localPosition = (new Vector3(neumatico4_controlador.transform.localPosition.x, neumatico4_controlador.transform.localPosition.y, neumatico4_controlador.transform.localPosition.z + cambio_transform_rueda1));
        transform_rueda4z = transform_rueda4z + cambio_transform_rueda1;
    }

    public void disminucion_llanta4_transformz()
    {
        neumatico4_controlador.transform.localPosition = (new Vector3(neumatico4_controlador.transform.localPosition.x, neumatico4_controlador.transform.localPosition.y, neumatico4_controlador.transform.localPosition.z - cambio_transform_rueda1));
        transform_rueda4z = transform_rueda4z - cambio_transform_rueda1;
    }

    //scale
    public void aumento_llanta4_scalex()
    {
        rueda4.transform.localScale = (new Vector3(rueda4.transform.localScale.x + cambio_escala_rueda1, rueda4.transform.localScale.y, rueda4.transform.localScale.z));
        escala_rueda4x = escala_rueda4x + cambio_escala_rueda1;
    }

    public void disminucion_llanta4_scalex()
    {
        rueda4.transform.localScale = (new Vector3(rueda4.transform.localScale.x - cambio_escala_rueda1, rueda4.transform.localScale.y, rueda4.transform.localScale.z));
        escala_rueda4x = escala_rueda4x - cambio_escala_rueda1;
    }

    public void aumento_llanta4_scaley()
    {
        rueda4.transform.localScale = (new Vector3(rueda4.transform.localScale.x, rueda4.transform.localScale.y + cambio_escala_rueda1, rueda4.transform.localScale.z));
        escala_rueda4y = escala_rueda4y + cambio_escala_rueda1;
    }

    public void disminucion_llanta4_scaley()
    {
        rueda4.transform.localScale = (new Vector3(rueda4.transform.localScale.x, rueda4.transform.localScale.y - cambio_escala_rueda1, rueda4.transform.localScale.z));
        escala_rueda4y = escala_rueda4y - cambio_escala_rueda1;
    }

    public void aumento_llanta4_scalez()
    {
        rueda4.transform.localScale = (new Vector3(rueda4.transform.localScale.x, rueda4.transform.localScale.y, rueda4.transform.localScale.z + cambio_escala_rueda1));
        escala_rueda4z = escala_rueda4z + cambio_escala_rueda1;
    }

    public void disminucion_llanta4_scalez()
    {
        rueda4.transform.localScale = (new Vector3(rueda4.transform.localScale.x, rueda4.transform.localScale.y, rueda4.transform.localScale.z - cambio_escala_rueda1));
        escala_rueda4z = escala_rueda4z - cambio_escala_rueda1;
    }

    //rotate
    public void aumento_llanta4_rotx()
    {
        rueda4.transform.Rotate(new Vector3(cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda4x = rotacion_rueda4x + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta4_rotx()
    {
        rueda4.transform.Rotate(new Vector3(-cambio_rotacion_rueda1, 0f, 0f));
        rotacion_rueda4x = rotacion_rueda4x - cambio_rotacion_rueda1;
    }

    public void aumento_llanta4_roty()
    {
        rueda4.transform.Rotate(new Vector3(0f, cambio_rotacion_rueda1, 0f));
        rotacion_rueda4y = rotacion_rueda4y + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta4_roty()
    {
        rueda4.transform.Rotate(new Vector3(0f, -cambio_rotacion_rueda1, 0f));
        rotacion_rueda4y = rotacion_rueda4y - cambio_rotacion_rueda1;
    }

    public void aumento_llanta4_rotz()
    {
        rueda4.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_rueda1));
        rotacion_rueda4z = rotacion_rueda4z + cambio_rotacion_rueda1;
    }

    public void disminucion_llanta4_rotz()
    {
        rueda4.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_rueda1));
        rotacion_rueda4z = rotacion_rueda4z - cambio_rotacion_rueda1;
    }

    //modificar variables de placa 4

    //transform
    public void aumento_placa4_transformx()
    {
        placa4_controlador.transform.localPosition = (new Vector3(placa4_controlador.transform.localPosition.x + cambio_transform_placa1, placa4_controlador.transform.localPosition.y, placa4_controlador.transform.localPosition.z));
        transform_placa4x = transform_placa4x + cambio_transform_placa1;
    }

    public void disminucion_placa4_transformx()
    {
        placa4_controlador.transform.localPosition = (new Vector3(placa4_controlador.transform.localPosition.x - cambio_transform_placa1, placa4_controlador.transform.localPosition.y, placa4_controlador.transform.localPosition.z));
        transform_placa4x = transform_placa4x - cambio_transform_placa1;
    }

    public void aumento_placa4_transformy()
    {
        placa4_controlador.transform.localPosition = (new Vector3(placa4_controlador.transform.localPosition.x, placa4_controlador.transform.localPosition.y + cambio_transform_placa1, placa4_controlador.transform.localPosition.z));
        transform_placa4y = transform_placa4y + cambio_transform_placa1;
    }

    public void disminucion_placa4_transformy()
    {
        placa4_controlador.transform.localPosition = (new Vector3(placa4_controlador.transform.localPosition.x, placa4_controlador.transform.localPosition.y - cambio_transform_placa1, placa4_controlador.transform.localPosition.z));
        transform_placa4y = transform_placa4y - cambio_transform_placa1;
    }

    public void aumento_placa4_transformz()
    {
        placa4_controlador.transform.localPosition = (new Vector3(placa4_controlador.transform.localPosition.x, placa4_controlador.transform.localPosition.y, placa4_controlador.transform.localPosition.z + cambio_transform_placa1));
        transform_placa4z = transform_placa4z + cambio_transform_placa1;
    }

    public void disminucion_placa4_transformz()
    {
        placa4_controlador.transform.localPosition = (new Vector3(placa4_controlador.transform.localPosition.x, placa4_controlador.transform.localPosition.y, placa4_controlador.transform.localPosition.z - cambio_transform_placa1));
        transform_placa4z = transform_placa4z - cambio_transform_placa1;
    }

    //scale

    public void aumento_placa4_scalex()
    {
        plak4.transform.localScale = (new Vector3(plak4.transform.localScale.x + cambio_escala_placa1, plak4.transform.localScale.y, plak4.transform.localScale.z));
        escala_placa4x = escala_placa4x + cambio_escala_placa1;
    }

    public void disminucion_placa4_scalex()
    {
        plak4.transform.localScale = (new Vector3(plak4.transform.localScale.x - cambio_escala_placa1, plak4.transform.localScale.y, plak4.transform.localScale.z));
        escala_placa4x = escala_placa4x - cambio_escala_placa1;
    }

    public void aumento_placa4_scaley()
    {
        plak4.transform.localScale = (new Vector3(plak4.transform.localScale.x, plak4.transform.localScale.y + cambio_escala_placa1, plak4.transform.localScale.z));
        escala_placa4y = escala_placa4y + cambio_escala_placa1;
    }

    public void disminucion_placa4_scaley()
    {
        plak4.transform.localScale = (new Vector3(plak4.transform.localScale.x, plak4.transform.localScale.y - cambio_escala_placa1, plak4.transform.localScale.z));
        escala_placa4y = escala_placa4y - cambio_escala_placa1;
    }

    public void aumento_placa4_scalez()
    {
        plak4.transform.localScale = (new Vector3(plak4.transform.localScale.x, plak4.transform.localScale.y, plak4.transform.localScale.z + cambio_escala_placa1));
        escala_placa4z = escala_placa4z + cambio_escala_placa1;
    }

    public void disminucion_placa4_scalez()
    {
        plak4.transform.localScale = (new Vector3(plak4.transform.localScale.x, plak4.transform.localScale.y, plak4.transform.localScale.z - cambio_escala_placa1));
        escala_placa4z = escala_placa4z - cambio_escala_placa1;
    }

    //rotate

    public void aumento_placa4_rotx()
    {
        plak4.transform.Rotate(new Vector3(cambio_rotacion_placa1, 0f, 0f));
        rotacion_placa4x = rotacion_placa4x + cambio_rotacion_placa1;
    }

    public void disminucion_placa4_rotx()
    {
        plak4.transform.Rotate(new Vector3(-cambio_rotacion_placa1, 0f, 0f));
        rotacion_placa4x = rotacion_placa4x - cambio_rotacion_placa1;
    }

    public void aumento_placa4_roty()
    {
        plak4.transform.Rotate(new Vector3(0f, cambio_rotacion_placa1, 0f));
        rotacion_placa4y = rotacion_placa4y + cambio_rotacion_placa1;
    }

    public void disminucion_placa4_roty()
    {
        plak4.transform.Rotate(new Vector3(0f, -cambio_rotacion_placa1, 0f));
        rotacion_placa4y = rotacion_placa4y - cambio_rotacion_placa1;
    }

    public void aumento_placa4_rotz()
    {
        plak4.transform.Rotate(new Vector3(0f, 0f, cambio_rotacion_placa1));
        rotacion_placa4z = rotacion_placa4z + cambio_rotacion_placa1;
    }

    public void disminucion_placa4_rotz()
    {
        plak4.transform.Rotate(new Vector3(0f, 0f, -cambio_rotacion_placa1));
        rotacion_placa4z = rotacion_placa4z - cambio_rotacion_placa1;
    }

    public void giro_zero()
    {
        giro = 0;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "vacio")
        {
            volver_inicio();
        }

        if (other.tag == "muro")
        {
            estabilizar();
            this.transform.localPosition = (new Vector3(this.transform.localPosition.x - 1.0f, this.transform.localPosition.y, this.transform.localPosition.z));
        }
    }

    public void volver_inicio()
    {
        giro = 0;
        this.transform.position = zona_inicio.transform.position;
        estabilizar();
    }


}
