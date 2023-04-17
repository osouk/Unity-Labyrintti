using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Seruaaminen : MonoBehaviour
{
    private NavMeshAgent vihollinen;
    public Transform pelaaja;

    private void Start()
    {
        pelaaja = GameObject.FindWithTag("Player").transform;
        vihollinen = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        vihollinen.SetDestination(pelaaja.position);
    }
}
