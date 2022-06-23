using System;
using System.Collections;
using System.Collections.Generic;
using TowerDefense.Singleton;
using UnityEngine;

namespace TowerDefense.Managers
{
    public class AudioManager : Singleton<AudioManager>
    {
        public AudioSource[] audioSFX;
        public AudioSource levelMusic, bossMusic, victoryMusic, loseMusic;
    

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
}