using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pelaaja : MonoBehaviour
{
    public Transform orientation;
    public Vector2 turn;

    public GameObject uiobject;

    public float sensitivity = .5f;

    public float Speed = 1f;

    public float MaxSpeed = 2f;

    public float AmmusNopeus = 200;

    Rigidbody rb;

    public GameObject Ammus;
    public Transform Piipunpaa;

    public Transform Kamera;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0, -50, 0);
    }
    private void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject go = Instantiate(Ammus, Piipunpaa.position, Quaternion.identity);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.AddForce(Kamera.forward * AmmusNopeus);
        }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
            uiobject.SetActive(true);
            StartCoroutine(WaitForSec());
            }
            
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        uiobject.SetActive(false);

    }

    private void FixedUpdate()
    {
        
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            float x2 = Input.GetAxis("Horizontal2");
            float z2 = Input.GetAxis("Vertical2");
            Vector3 suunta = transform.forward * z + transform.right * x;
            rb.velocity = suunta * Speed;
            suunta.y = 0;
           // rb.AddForce(suunta * Speed * Time.fixedDeltaTime);
      //  rb.velocity.Normalize();

    }
}
