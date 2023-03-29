using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vihollinen : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject effect;

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ammus")
        {
            Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);
            Destroy(objToDestroy);
            Destroy(gameObject);
        }
    }
}