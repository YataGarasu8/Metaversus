using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSource : MonoBehaviour
{
    AudioSource audioSource;
   
    public void SoundPlay(AudioClip clip, float soundEffectVolume)
    {
        if (audioSource == null)
        {audioSource = GetComponent<AudioSource>();}

        CancelInvoke();
        audioSource.clip = clip;
        audioSource.volume = soundEffectVolume;
        audioSource.Play();
    }
}
