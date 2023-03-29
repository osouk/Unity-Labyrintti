using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyRayCastTesti : RayCastTesti
{   
    public float throwForce = 200;
    
    private GameObject Target;
   // public Transform kasi;
    public Transform kasi2;
    private GameObject Napattu = null;
    
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Target != null && Napattu == null)
            {
                Target.transform.position = kasi2.position;
                Napattu = Target;
                Rigidbody RB = Target.GetComponent<Rigidbody>();
                RB.useGravity = false;
                RB.freezeRotation = true;
                RB.isKinematic = true;
            }
            else
            {
                Rigidbody RB = Napattu.GetComponent<Rigidbody>();
                RB.useGravity = true;
                RB.freezeRotation = false;
                Napattu = null;
                RB.isKinematic = false;           
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Rigidbody RB = Napattu.GetComponent<Rigidbody>();
            RB.useGravity = true;
            RB.freezeRotation = false;
            Napattu = null;
            RB.isKinematic = false;
            RB.AddForce(kasi2.forward * throwForce);
        }


        if (Napattu)
        {
            Napattu.transform.position = kasi2.position;
        }
    }
    void FixedUpdate()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2, layerMask))
            {
                Target = hit.transform.gameObject;
            }
            else
                Target = null;
        }
    }

