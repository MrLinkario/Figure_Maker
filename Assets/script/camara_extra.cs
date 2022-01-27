using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_extra : MonoBehaviour
{
    public GameObject zona_restart;

    public float desplazamiento;
    public float giro;

    bool move_right;
    bool move_left;
    bool move_up;
    bool move_down;
    // Start is called before the first frame update
    void Start()
    {
        move_right=false;
        move_left=false;
        move_up=false;
        move_down=false;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.localPosition=new Vector3(this.transform.localPosition.x, this.transform.localPosition.y , this.transform.localPosition.z + desplazamiento);
        this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y + giro, this.transform.rotation.z);

        boton_derecha();
        boton_izquierda();
        boton_arriba();
        boton_abajo();

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
            giro += 1.0f;
        }
    }

    public void move_leftOn()
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
            giro -= 1.0f;
        }
    }

    public void move_upOn()
    {
        move_up = true;
    }
    public void upOff()
    {
        move_up = false;
    }

    public void boton_arriba()
    {
        if (move_up)
        {
            //desplazamiento += 0.1f; 
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }
    }

    public void move_downOn()
    {
        move_down = true;
    }
    public void downOff()
    {
        move_down = false;
    }

    public void boton_abajo()
    {
        if (move_down)
        {
            //desplazamiento -= 0.1f;
            this.transform.Translate(0.0f, 0.0f, -0.1f);
        }
    }

    public void volver_inicio()
    {
        this.transform.position = zona_restart.transform.position;
        desplazamiento = 0;
        giro = 0;
    }

    public void moveUp()
    {
        //desplazamiento += 0.1f;
        //this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z + 0.1f);
        this.transform.Translate(0.0f, 0.0f, 0.1f);
    }

    public void moveDown()
    {
        //desplazamiento -= 0.1f;
        //this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z - 0.1f);
        this.transform.Translate(0.0f, 0.0f, - 0.1f);
    }




}
