using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ohjeet : MonoBehaviour
{
    public GameObject uiObject;

    private void Start()
    {
        StartCoroutine("WaitForSec");
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(15);
        Destroy(uiObject);
       
    }
}
