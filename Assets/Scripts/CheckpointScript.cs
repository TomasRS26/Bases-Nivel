using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    // GameObject para referenciar el objeto de checkpoint
    public GameObject ReferenciaCheck;


    //Vector para guardar posición de respawn
    Vector3 PuntoSpawn;


    void Start()
    {
        //configuracion del punto de spawn al iniciar la partida, el cual es el inicio del nivel mismo
        PuntoSpawn = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Activadores provisionales
        if (Input.GetKeyDown(KeyCode.K))
        {
            MuerteJugador();
        }
     

        if (Input.GetKeyDown(KeyCode.L))
        {
            RecogerCheckpoint();
        }
    }

    void MuerteJugador()
    {
        gameObject.transform.position = PuntoSpawn;
    }

    void RecogerCheckpoint()
    {
        PuntoSpawn = ReferenciaCheck.transform.position;
        Destroy(ReferenciaCheck);
    }
}
