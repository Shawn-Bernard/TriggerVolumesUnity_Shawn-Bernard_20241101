using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColor : MonoBehaviour
{
    public Light Lt;

    Color color0 = Color.red;
    Color color1 = Color.white;
    void OnTriggerEnter(Collider other)
    {
        Lt.color = color0;
    }

    void OnTriggerExit(Collider other)
    {
        Lt.color = color1;
    }
}
