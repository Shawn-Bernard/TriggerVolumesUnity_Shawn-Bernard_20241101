using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSetActive : MonoBehaviour
{ 
    public Light Light;
    
    public Material Wanted;
    public Material notWanted;

    public Renderer Render;

    public GameObject Picture;

    private void Start()
    {
        Render = Picture.GetComponent<Renderer>();
    }
    void OnTriggerEnter(Collider other)
    {
        Render.material = notWanted;
        // Getting the component for picture and making the material equal to my public material I put in

        Light.enabled = false;
        // Making The light component false
        
    }

    void OnTriggerExit(Collider other)
    {
        Light.enabled = true;
        Render.material = Wanted;
    }       
}
