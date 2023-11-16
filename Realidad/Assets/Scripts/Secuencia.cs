using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Secuencia : MonoBehaviour
{

    public int numeroNecesario;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rayo"))
        {
            if (numeroNecesario == SecuenciaManaller.Instance.Counter)
            {
                SecuenciaManaller.Instance.Counter++;
                SecuenciaManaller.Instance.Comprovacion();
            }
            else
            {
                SecuenciaManaller.Instance.Counter = 0;
            }
        }
    }
}
