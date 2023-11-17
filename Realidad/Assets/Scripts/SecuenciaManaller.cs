using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecuenciaManaller : MonoBehaviour
{
    public int Counter = 0;
    public int NumeroNecesario = 4;
    public GameObject Techo;
    //public GameObject cuerda;
    
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
            Techo.SetActive(false);
            //cuerda.SetActive(true);
            //Debug.Log("Añadir eventos");
            SceneManager.LoadScene("3.Fin");
        }
    }
}
