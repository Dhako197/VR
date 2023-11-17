using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PanelManager : MonoBehaviour
{
    private bool hecho = false;
    [SerializeField] private Material newMaterialA;
    public PlayableDirector Activation;
    public GameObject light; 
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rayo") && !hecho)
        {
            MeshRenderer meshRenderer = light.GetComponent<MeshRenderer>();

    
            Material[] materials = meshRenderer.materials;

    
            if (materials.Length > 2)
            {
              
                materials[2] = newMaterialA;

        
                meshRenderer.materials = materials;
                
                
            }
            Activation.Play();
            hecho = true;
        }
    }
}
