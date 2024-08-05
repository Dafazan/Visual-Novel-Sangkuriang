using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using TMPro;

public class take2 : MonoBehaviour
{
    public VideoPlayer videoPlayerT1;
    public VideoPlayer videoPlayerT2;

    public GameObject T1;
    public GameObject T2;

    public GameObject T2Dialogue;
    public GameObject SkipBtn1;
    public GameObject NextBtn1;
    public GameObject Nextscene1;
    public TextMeshProUGUI textcomponent;
    public string[] lines;
    public float textSpeed;
    private int index;

    public AudioClip[] audioClips;
    public AudioSource audioSource;


    void Start()
    {
        StartDialogue1();
        videoPlayerT1.loopPointReached += OnVideoEnded;
        //videoPlayerT1.Pause();
        
    }

    void OnVideoEnded(VideoPlayer vp)
    {
        T2.SetActive(false);
        videoPlayerT2.Play();
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
            StartCoroutine(TypeLine1());
            NextBtn1.SetActive(false);
            SkipBtn1.SetActive(true);
        }
        else
        {
            T2Dialogue.SetActive(false);
            T1.SetActive(false);
            videoPlayerT1.Play();
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