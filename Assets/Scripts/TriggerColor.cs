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

    public Renderer Render;

    public GameObject Bulb;
    private void Start()
    {
        Render = Bulb.GetComponent<Renderer>();
    }
    void OnTriggerEnter(Collider other)
    {
        Render.material = RedBulb;
        Lt.color = color0;

    }

    void OnTriggerExit(Collider other)
    {
        Render.material = WhiteBulb;
        Lt.color = color1;
    }
}
