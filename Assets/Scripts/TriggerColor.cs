using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColor : MonoBehaviour
{
    public Light Lt;

    Color color0 = Color.red;
    Color color1 = Color.yellow;

    public Material WhiteBulb;
    public Material RedBulb;

    public GameObject Bulb;
    void OnTriggerEnter(Collider other)
    {
        Bulb.GetComponent<Renderer>().material = RedBulb;
        Lt.color = color0;
    }

    void OnTriggerExit(Collider other)
    {
        Bulb.GetComponent<Renderer>().material = WhiteBulb;
        Lt.color = color1;
    }
}
