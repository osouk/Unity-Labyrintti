using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaannaKamera : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    Rigidbody rb;

    float xKaannos;
    float yKaannos;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yKaannos += mouseX;

        xKaannos += mouseY;
        xKaannos = Mathf.Clamp(xKaannos, -90f, 90f);

        transform.rotation = Quaternion.Euler(xKaannos, yKaannos, 0);
        orientation.rotation = Quaternion.Euler(0, yKaannos, 0);
        
    }
}
