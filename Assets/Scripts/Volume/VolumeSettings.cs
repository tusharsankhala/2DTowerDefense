using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject volumeControlWindow;
    public Slider masterSlider;   
    public Slider sfxSlider;
    public Slider musicSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            audioMixer.SetFloat("MasterVolume",PlayerPrefs.GetFloat("MasterVolume"));
            audioMixer.SetFloat("SFXVolume",PlayerPrefs.GetFloat("SFXVolume"));
            audioMixer.SetFloat("MusicVolume",PlayerPrefs.GetFloat("MusicVolume"));
            
            SetSlider();
        }
        else
        {
            SetSlider();
        }
    }

    void SetSlider()
    {
        masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
            volumeControlWindow.SetActive(!volumeControlWindow.activeInHierarchy);
    }

    public void UpdateMasterVolume()
    {
        audioMixer.SetFloat("MasterVolume", masterSlider.value);
        PlayerPrefs.SetFloat("MasterVolume", masterSlider.value);
    }
    
    public void UpdateSFXVolume()
    {
        audioMixer.SetFloat("SFXVolume", sfxSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", sfxSlider.value);
    }
    
    public void UpdateMusicVolume()
    {
        audioMixer.SetFloat("MusicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
    }
}