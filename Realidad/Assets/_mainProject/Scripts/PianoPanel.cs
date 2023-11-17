using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoPanel : MonoBehaviour
{
    public GameObject melodia;
    private bool isInCooldown = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rayo") && !isInCooldown )
        {
            melodia.SetActive(true);
            isInCooldown = true;
            //StartCoroutine(Cooldown());
        }
    }

    IEnumerator Cooldown()
    {
       yield return new WaitForSeconds(10);
        isInCooldown = false;
    }
}

