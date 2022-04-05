using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : SingletonPattern<SoundManager>
{
    public AudioSource audiosource;
    public bool isPlaying;

    public void PlayAudio()
    {
        isPlaying = true;
        audiosource.Play();
    }

    public void PlayAudioClip(AudioClip clip)
    {
       audiosource.PlayOneShot(clip);
    }

    public void PauseAudio()
    {
        isPlaying=false;
        audiosource.Pause();
    }

    public void ChangeVolume( float val)
    {
         AudioListener.volume = val;
    }

}
