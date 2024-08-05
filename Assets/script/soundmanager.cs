using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider volumeSliderD;
    // Corrected here
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicvolume"))
        {
            PlayerPrefs.SetFloat("musicvolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        if (!PlayerPrefs.HasKey("dialvolume"))
        {
            PlayerPrefs.SetFloat("dialvolume", 1);
            LoadD();
        }
        else
        {
            LoadD();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        //AudioListener.volume = volumeSlider.value;
        Save();
    }
    public void ChangeVolumeD()
    {
        //AudioListener.volume = volumeSlider.value;
        SaveD();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicvolume");
       
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicvolume", volumeSlider.value);
       
    }
    private void LoadD()
    {
       
        volumeSlider.value = PlayerPrefs.GetFloat("dialvolume");
    }

    private void SaveD()
    {
        
        PlayerPrefs.SetFloat("dialvolume", volumeSlider.value);
    }
}
