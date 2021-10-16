using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public GameObject objetivoSpawn;
    public GameObject jugador;

    void OnTriggerEnter(Collider other)
    {
        jugador.transform.position = objetivoSpawn.transform.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
