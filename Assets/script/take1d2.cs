using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class take1d2 : MonoBehaviour
{
    public VideoPlayer videoPlayerT2;
    
    public GameObject T2Dialogue;
    public GameObject SkipBtn1;
    public GameObject NextBtn1;
    public GameObject Nextscene1;
    public TextMeshProUGUI textcomponent;
    public string[] lines;
    public TextMeshProUGUI name;
    public string[] names;
    public float textSpeed;
    private int index;

    public AudioClip[] audioClips;
    public AudioSource audioSource;

    

    void Start()
    {
        videoPlayerT2.loopPointReached += OnVideoEnded;
    }

    void Update()
    {
        textSpeed = PlayerPrefs.GetFloat("textspeed", 0.03f);
    }

    void OnVideoEnded(VideoPlayer vp)
    {
        T2Dialogue.SetActive(true);
        StartDialogue1();
    }

    void StartDialogue1()
    {
        index = 0;
        StartCoroutine(TypeLine1());
    }

    IEnumerator TypeLine1()
    {
        if (audioClips != null && audioClips.Length > index && audioClips[index] != null)
        {
            audioSource.clip = audioClips[index];
            audioSource.Play();
        }
        foreach (char c in names[index].ToCharArray())
        {
            name.text += c;

        }
        foreach (char c in lines[index].ToCharArray())
        {
            textcomponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        NextBtn1.SetActive(true);
        SkipBtn1.SetActive(false);
    }


    public void Nextline1()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textcomponent.text = string.Empty;
            name.text = string.Empty;
            StartCoroutine(TypeLine1());
            NextBtn1.SetActive(false);
            SkipBtn1.SetActive(true);
        }
        else
        {
            T2Dialogue.SetActive(false);
            SceneManager.LoadScene("Take2");
        }
    }

    public void skip1()
    {
        StopAllCoroutines();
        textcomponent.text = lines[index];
        NextBtn1.SetActive(true);
        SkipBtn1.SetActive(false);
        audioSource.Stop();
    }

}