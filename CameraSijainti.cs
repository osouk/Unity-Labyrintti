using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSijainti : MonoBehaviour
{
    public Transform cameraSijainti;

    private void Update()
    {
        transform.position = cameraSijainti.position;
    }
}
