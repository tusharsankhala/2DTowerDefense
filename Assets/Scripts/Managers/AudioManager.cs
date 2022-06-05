using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [NonSerialized]
    public static AudioManager _mInstance;

    private AudioSource[] _mAudioSFX;
    public AudioSource levelMusic, bossMusic, victoryMusic, loseMusic;

    private void Awake()
    {
        _mInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        levelMusic.Play();
    }

    void StopAllMusic()
    {
        levelMusic.Stop();
        bossMusic.Stop();
        victoryMusic.Stop();
        loseMusic.Stop();
    }
    
    void PlayLevelMusic()
    {
        StopAllMusic();
        levelMusic.Play();
    }
    
    void PlayBossMusic()
    {
        StopAllMusic();
        bossMusic.Stop();
    }
    
    void PlayVictoryMusic()
    {
        StopAllMusic();
        victoryMusic.Stop();
    }
    
    void PlayLoseMusic()
    {
        StopAllMusic();
        loseMusic.Stop();
    }
    
    public void PlaySFX(int sfx)
    {
        _mAudioSFX[sfx].Stop();
        _mAudioSFX[sfx].Play();
    }
}