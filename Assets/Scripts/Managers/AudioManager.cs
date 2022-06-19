using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [NonSerialized]
    private static AudioManager _mInstance;

    public AudioSource[] audioSFX;
    public AudioSource levelMusic, bossMusic, victoryMusic, loseMusic;

    public static AudioManager Instance
    {
        get
        {
            return _mInstance;
        }
    }
    
    private void Awake()
    {
        if (_mInstance == null)
        {
            _mInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
        audioSFX[sfx].Stop();
        audioSFX[sfx].Play();
    }
}