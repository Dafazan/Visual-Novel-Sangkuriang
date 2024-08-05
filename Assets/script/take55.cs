using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class take55 : MonoBehaviour
{
    public VideoPlayer videoPlayerT1;
    public VideoPlayer videoPlayerT2;

    public GameObject T1;
    public GameObject T2;
    public GameObject BRS;

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



    void Start()
    {
        videoPlayerT1.loopPointReached += OnVideoEnded;
        T2Dialogue.SetActive(true);
        textcomponent.text = string.Empty;
        StartDialogue1();
    }
    void OnVideoEnded(VideoPlayer vp)
    {
        BRS.SetActive(true);
       
    }


    public void StartVideo()
    {
        if (videoPlayerT1 != null)
        {

            videoPlayerT1.Play();
        }
        T2Dialogue.SetActive(true);
        textcomponent.text = string.Empty;
        StartDialogue1();
    }


    private void ClearRenderTexture()
    {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = videoPlayerT1.targetTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }



    void StartDialogue1()
    {
        index = 0;
        StartCoroutine(TypeLine1());
    }

    IEnumerator TypeLine1()
    {
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
            name.text = string.Empty;
            textcomponent.text = string.Empty;
            StartCoroutine(TypeLine1());
            NextBtn1.SetActive(false);
            SkipBtn1.SetActive(true);

        }
        else
        {

            NewScene();
        }
    }
    public void NewScene()
    {
        T1.SetActive(false);
        T2.SetActive(true);
        T2Dialogue.SetActive(false);
        videoPlayerT1.Play();
    }



    public void skip1()
    {
        StopAllCoroutines();
        textcomponent.text = lines[index];
        NextBtn1.SetActive(true);
        SkipBtn1.SetActive(false);
    }

    public void bersambung()
    {
        SceneManager.LoadScene("Quiz2");
    }
    public void home()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
