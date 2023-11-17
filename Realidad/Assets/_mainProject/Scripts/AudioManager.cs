using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixerSnapshot transitionPianoAudio; 
    public AudioMixerSnapshot transitionFullAudio;

    public void PianoAudioZero()
    {
        transitionPianoAudio.TransitionTo(2f);
    }
    
    public void PianoAudioFull()
    {
        transitionFullAudio.TransitionTo(1f);
    }
}
