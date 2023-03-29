/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yeetus : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 200;
    bool hasPlayer = false;
    bool beingCarried = false;

    public AudioClip[] SoundToPlay;
    private AudioSource audio;
    private bool touched = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true;
        }
        else
        {
           hasPlayer = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                RandomAudio();
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }
    void RandomAudio()
    {
        if (audio.isPlaying)
        {
            return;
        }
        audio.clip = SoundToPlay[Random.Range(0, SoundToPlay.Length)];
        audio.Play();
    }
    private void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}
*/
