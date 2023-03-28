using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinss : MonoBehaviour
{
    public int Pisteet = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Kävyt: " + Pisteet);
    }
}
