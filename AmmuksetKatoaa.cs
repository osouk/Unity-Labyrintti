using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmuksetKatoaa : MonoBehaviour
{
    public GameObject Ammus;

    private void Start()
    {
        StartCoroutine("Odota");
    }
    IEnumerator Odota()
    {
        yield return new WaitForSeconds(2);
        Destroy(Ammus);

    }
}
