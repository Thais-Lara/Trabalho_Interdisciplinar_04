using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent inimigo;
    private Transform point;
    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
        point = GameObject.Find("PolyArtWizardMaskTintMat").transform;
    }

    // Update is called once per frame
    void Update()
    {
        inimigo.SetDestination(point.position);
    }
}
