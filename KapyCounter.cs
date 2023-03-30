using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapyCounter : MonoBehaviour
{
    private Coinss C;
    public GameObject RemoveObj;

    private void Start()
    {
        C = FindObjectOfType<Coinss>();
    }

    private void Update()
    {
        if (C.Pisteet >= 5)
        {
            Destroy(RemoveObj);
        }
    }
}
