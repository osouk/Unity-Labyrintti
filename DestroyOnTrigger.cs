using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject effect;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

        Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);
            Destroy(objToDestroy);
            Destroy(gameObject);
    }
}
