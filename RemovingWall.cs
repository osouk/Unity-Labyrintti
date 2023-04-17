using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovingWall : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {     
            uiObject.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(6f);
        Destroy(uiObject);
    }
}
