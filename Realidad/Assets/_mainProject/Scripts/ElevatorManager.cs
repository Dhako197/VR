using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ElevatorManager : MonoBehaviour
{
    public bool hecho = false;

    public bool Library = true; 
    public bool Lab = false;

    public bool changetoLibrary = false; 
    public bool changetoLab = false;
    public bool Elevator = false; 

    public PlayableDirector toLab; 
    public PlayableDirector toLibrary;

    public ElevatorManager elevatorManager; 
    
 
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hecho)
        {
           if (Library && !Lab && Elevator)
           {
               
               hecho = true; 
               toLab.Play();
           }
           
           if (Lab && !Library && Elevator)
           {
               hecho = true; 
               toLibrary.Play();
           }

           if (changetoLibrary)
           {
               elevatorManager.Library = true;
               elevatorManager.Lab = false;
               elevatorManager.hecho = false; 
           }
           
           if (changetoLab)
           {
               elevatorManager.Lab = true;
               elevatorManager.Library = false;
               elevatorManager.hecho = false; 
           }
           
        }
    }
    
    
    
}
