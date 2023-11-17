using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartGame : MonoBehaviour
{
    private bool hecho = false;
    public PlayableDirector GameSTART; 

    public void StartGameBool()
    {
        if (!hecho)
        {
            hecho = true;
            GameSTART.Play();
            this.gameObject.SetActive(false);
            
        }
    }
}
