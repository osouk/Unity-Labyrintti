using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tasoTwoFinish : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("Next");
        }
    }

    IEnumerator Next()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainMenu");
    }
}
