using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Secuencia : MonoBehaviour
{

    public int numeroNecesario;
    private bool hecho = false;

    private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("Rayo") && !hecho)
         {
             if (numeroNecesario == SecuenciaManaller.Instance.Counter)
             {
                 hecho = true; 
                 SecuenciaManaller.Instance.Counter++;
                 SecuenciaManaller.Instance.Comprovacion();
                 StartCoroutine(ColdownNote()); 
                  Debug.Log("Si funciono el otro");
             }
             else
             {
                 SecuenciaManaller.Instance.Counter = 0;
             }
         }
     }
     
    IEnumerator ColdownNote()
    {
        yield return new WaitForSeconds(0.5f);
        hecho = false; 
    }

    public void Contador()
    {
       /* if (!hecho){
            if (numeroNecesario == SecuenciaManaller.Instance.Counter)
            {
                SecuenciaManaller.Instance.Counter++;
                SecuenciaManaller.Instance.Comprovacion();
                hecho = true;
                StartCoroutine(ColdownNote());
            }
            else
            {
                SecuenciaManaller.Instance.Counter = 0;
            }

            Debug.Log("Si funciono");
            
        }
        */
    }
}
