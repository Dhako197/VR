using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalsFX2_ActivatonDelay : MonoBehaviour {
    
        public GameObject objectToActivate;
        public GameObject window; 
    public float Delay;

        private void Start()
        {
            StartCoroutine(ActivationRoutine());
        }

        private IEnumerator ActivationRoutine()
        {
      
            yield return new WaitForSeconds(Delay);
            
            objectToActivate.SetActive(true);
            yield return new WaitForSeconds(Delay);
            window.SetActive(false);

 
        }
    }
