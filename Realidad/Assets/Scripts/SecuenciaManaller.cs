using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuenciaManaller : MonoBehaviour
{
    public int Counter = 0;
    public int NumeroNecesario = 4;
    
    public static SecuenciaManaller Instance { get; private set; }
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
    
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public void Comprovacion()
    {
        if (Counter == NumeroNecesario)
        {
            Debug.Log("Añadir eventos");
        }
    }
}
