using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayo : MonoBehaviour
{
    private Secuencia secuancia;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bateria"))
        {
            secuancia = other.gameObject.GetComponent<Secuencia>();
            secuancia.Contador();
        }
    }
}
