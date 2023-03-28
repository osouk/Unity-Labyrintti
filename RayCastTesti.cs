using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTesti : MonoBehaviour
{
    public float selectionDistance = 1f;
    public LayerMask layerMask;

    private GameObject Kohde;

     void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, selectionDistance, layerMask))
        {
            if(Kohde == null)
            {
                Kohde = hit.transform.gameObject;
                OnRaycastEnter(Kohde);
            }
            else if (Kohde != hit.transform.gameObject)
            {
                OnRaycastLeave(Kohde);
                Kohde = hit.transform.gameObject;
                OnRaycastEnter(Kohde);
            }
            OnRaycast(hit.transform.gameObject);
        }
        else if (Kohde != null)
        {
            OnRaycastLeave(Kohde);
            Kohde = null;
        }
    }

   protected virtual void OnRaycastEnter(GameObject target)
    { }
   protected virtual void OnRaycastLeave(GameObject target)
    { }
   protected virtual void OnRaycast(GameObject target)
    { }

}
