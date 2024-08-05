using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanagerdial : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    
    void Start()
    {
        if (!PlayerPrefs.HasKey("dialvolume"))
        {
            PlayerPrefs.SetFloat("dialvolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        //AudioListener.volume = volumeSlider.value;
        Save();
    }
    

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("dialvolume");
       
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("dialvolume", volumeSlider.value);
       
    }
    
}
