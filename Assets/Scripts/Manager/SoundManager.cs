using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;

    [SerializeField][Range(0f, 1f)] float soundEffectVolume;
    [SerializeField][Range(0f, 1f)] float musicVolume;

    AudioSource musicAudioSource;
    public AudioClip musicClip;

    public SoundSource SoundSourcePrefab;

    private void Awake()
    {
        soundManager = this;
        musicAudioSource = GetComponent<AudioSource>();
        musicAudioSource.volume = musicVolume;
        musicAudioSource.loop = true;
    }
    private void Start()
    {
        
    }
    public void ChangeBgm(AudioClip clip)
    {
        musicAudioSource.Stop();
        musicAudioSource.clip = clip;
        musicAudioSource.Play();
    }
    public static void PlayClip(AudioClip clip)
    {
        SoundSource obj = Instantiate(soundManager.SoundSourcePrefab);
        SoundSource soundSource = obj.GetComponent<SoundSource>();
        soundSource.SoundPlay(clip, soundManager.soundEffectVolume);
    }
}
