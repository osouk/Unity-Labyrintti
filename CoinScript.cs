using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {

            other.GetComponent<Coinss>().Pisteet++;
            Destroy(gameObject);
        }
    }
}
