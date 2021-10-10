using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaFlotanteScript : MonoBehaviour
{
    //Variables
    public float VelocidadCaida;
    float Recuperacion = 100f;

    bool CaidaRoca = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Caida de la Roca
        if (CaidaRoca == true)
        {
            Vector2 movimiento = new Vector2(0, -VelocidadCaida * Time.deltaTime);
            transform.Translate(movimiento);

            Recuperacion = Recuperacion - 1 * Time.deltaTime;
        }
        else if (CaidaRoca == false)
        {

            if(Recuperacion < 100)
            {
                Vector2 movimiento = new Vector2(0, VelocidadCaida * Time.deltaTime);
                transform.Translate(movimiento);

                Recuperacion = Recuperacion + 1 * Time.deltaTime;
            }
            else if(Recuperacion >= 100)
            {
                Vector2 movimiento = new Vector2(0, 0);
                transform.Translate(movimiento);

                Recuperacion = 100f;
            }
        }

    }


    //colisiones
    public void ActivarRocaFlotante ()
    {
        CaidaRoca = true;
        Debug.Log("Caida Activada");
        Debug.Log(CaidaRoca);
    }

    public void DesactivarRocaFlotante()
    {
        CaidaRoca = false;
        Debug.Log("Caida Desactivada");
        Debug.Log(CaidaRoca);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ActivarRocaFlotante();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DesactivarRocaFlotante();
        }
    }

}
