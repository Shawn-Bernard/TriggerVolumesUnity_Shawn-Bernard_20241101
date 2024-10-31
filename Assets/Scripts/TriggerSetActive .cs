using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSetActive : MonoBehaviour
{ 
    public Light Light;
    
    public Material Wanted;
    public Material notWanted;
    
    public GameObject Picture;
    
    void OnTriggerEnter(Collider other)
    {
        Picture.GetComponent<Renderer>().material = notWanted;


        Light.enabled = false;
        
        
        
        
        //Sprite.texture = null;
    }

    void OnTriggerExit(Collider other)
    {
        Light.enabled = true;
        Picture.GetComponent<Renderer>().material = Wanted;
    }       
}
