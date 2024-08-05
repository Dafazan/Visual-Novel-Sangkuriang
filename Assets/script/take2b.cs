using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class take2b : MonoBehaviour
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

    void Start()
    {
    
        videoPlayerT1.loopPointReached += OnVideoEnded;
        //videoPlayerT1.Pause();
        
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
            SceneManager.LoadScene("Take3");
            T2Dialogue.SetActive(false);
          
        }
    }

    public void skip1()
    {
        StopAllCoroutines();
        textcomponent.text = lines[index];
        NextBtn1.SetActive(true);
        SkipBtn1.SetActive(false);
    }

}