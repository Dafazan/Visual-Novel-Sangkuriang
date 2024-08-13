using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class narrate : MonoBehaviour
{
    public GameObject Startd;
    public GameObject camera;
    public GameObject text;
    public GameObject SkipBtn1;
    public GameObject NextBtn1;

    public TextMeshProUGUI textcomponent;
    public string[] lines;
    public AudioClip[] audioClips;
    public AudioSource audioSource;


    public float textSpeed;
    private int index;



    void Start()
    {
        StartDialogue1();
    }

    // Update is called once per frame
    void Update()
    {
        textSpeed = PlayerPrefs.GetFloat("textspeed", 0.03f);
    }

    public void startnarrate()
    {
        Startd.SetActive(true);
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
            SceneManager.LoadScene("Take 1");
        }
    }

    public void skip1()
    {
        StopAllCoroutines();
        textcomponent.text = lines[index];
        audioSource.Stop();
        NextBtn1.SetActive(true);
        SkipBtn1.SetActive(false);
    }

}
