using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vihollinen : MonoBehaviour
{
    public GameObject vihollinen;

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ammus")
        {
            Destroy(vihollinen);
        }
     }
}
