using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class settingsMenu : MonoBehaviour

{
   
    public TMP_Dropdown qualityDropdown;

    //public int qualityIndex = 4;
    public AudioMixer audioMixer;

     void Start()
    {
        QualitySettings.SetQualityLevel(3);
        qualityDropdown.value = 3;

    }
    public void setVolume (float volume)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }
    public void SetQuality (int qualityIndex)
    {
        qualityIndex = qualityDropdown.value;
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
