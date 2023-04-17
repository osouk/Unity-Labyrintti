using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinss : MonoBehaviour
{
    public AudioClip SoundToPlay;

    AudioSource audio;
    public bool alreadyPlayed = false;

    public int Pisteet = 0;

    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject uiObject3;

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 30), "Pinecones: " + Pisteet);
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        uiObject3.SetActive(false);
    }

    private void Update()
    {
        if(Pisteet == 5)
        {
            StartCoroutine(odota2());
            Destroy(uiObject3);
            uiObject2.SetActive(true);
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(SoundToPlay);
                alreadyPlayed = true;
            }
        }
        else if(Pisteet < 5)
        {
            uiObject3.SetActive(true);
        }       

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

    IEnumerator odota2()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject2);
    }
}
