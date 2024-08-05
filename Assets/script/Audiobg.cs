//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Audiobg : MonoBehaviour
//{
//    private static Audiobg instance;
//    [SerializeField] AudioSource musicSource;
//    private const string MusicVolumeKey = "musicvolume";


//    private void LoadVolumeSettings()
//    {
//        if (PlayerPrefs.HasKey(MusicVolumeKey))
//        {
//            musicSource.volume = PlayerPrefs.GetFloat(MusicVolumeKey);
//        }
//        else
//        {
//            musicSource.volume = 1f; // Default volume if not set
//        }

//        if (PlayerPrefs.HasKey(SfxVolumeKey))
//        {
//            sfxSource.volume = PlayerPrefs.GetFloat(SfxVolumeKey);
//        }
//        else
//        {
//            sfxSource.volume = 1f; // Default volume if not set
//        }
//    }

//    void Update() {

//        LoadVolumeSettings();
//    }


//    private void Awake()
//    {
//        if (instance == null)
//        {
//            // If instance doesn't exist, set it to this instance
//            instance = this;
//            DontDestroyOnLoad(gameObject); // Prevent AudioManager from being destroyed on scene load
//        }
//        else
//        {
//            // If an instance already exists, destroy this instance
//            Destroy(gameObject);
//        }
//    }

//    void Start()
//    {
//        AudioSource audioSource = GetComponent<AudioSource>();
//        if (audioSource != null)
//        {
//            audioSource.Play();
//        }
//    }

//    public void PlayAudio()
//    {

//    }
//}
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audiobg : MonoBehaviour
{
    private static Audiobg instance;
    [SerializeField] private AudioSource musicSource;
    private const string MusicVolumeKey = "musicvolume";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Start()
    {
       
        PlayAudio();
    }

    void Update()
    {
        LoadVolumeSettings();
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        LoadVolumeSettings();
        PlayAudio();
    }

    private void LoadVolumeSettings()
    {
        if (musicSource != null)
        {
            musicSource.volume = PlayerPrefs.GetFloat(MusicVolumeKey, 1f); // Default volume if not set
        }
    }

    public void SetMusicVolume(float volume)
    {
        if (musicSource != null)
        {
            musicSource.volume = volume;
            PlayerPrefs.SetFloat(MusicVolumeKey, volume);
            PlayerPrefs.Save(); // Ensure the volume setting is saved immediately
        }
    }

    public void PlayAudio()
    {
        if (musicSource != null && !musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }
}
