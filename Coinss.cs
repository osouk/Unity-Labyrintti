using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coinss : MonoBehaviour
{
    public int Pisteet = 0;
    public GameObject uiObject; 

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Kävyt: " + Pisteet);
    }

    void Start()
    {
        uiObject.SetActive(false);
    }

    private void Update()
    {
        if(Pisteet == 8)
        {
            uiObject.SetActive(true);
            StartCoroutine("odota");
        }
    }

    IEnumerator odota()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
    }
}
