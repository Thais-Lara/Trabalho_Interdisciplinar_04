using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Ainimigo : MonoBehaviour
{

    NavMeshAgent agente;
    public Transform target;
   

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = target.position;
    }
}
