using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class take51 : MonoBehaviour
{
    public VideoPlayer videoPlayerT1;
    public VideoPlayer videoPlayerT2;
    public VideoPlayer videoPlayerT3;

    public GameObject T1;
    public GameObject T2;
    public GameObject T3;

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
        videoPlayerT2.loopPointReached += OnVideoEnded;
        T2Dialogue.SetActive(true);
        textcomponent.text = string.Empty;
        StartDialogue1();
    }


    public void StartVideo()
    {
        
    }

    void Update()
    {
        textSpeed = PlayerPrefs.GetFloat("textspeed", 0.03f);
    }


    private void ClearRenderTexture()
    {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = videoPlayerT1.targetTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }
    private void ClearRenderTexture2()
    {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = videoPlayerT2.targetTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }
    private void ClearRenderTexture3()
    {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = videoPlayerT3.targetTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }





    void PlayVideo2()
    {
        T2.SetActive(true);

        if (videoPlayerT2 != null)
        {
            videoPlayerT2.Play();
        }
        T1.SetActive(false);
    }

    void OnVideoEnded(VideoPlayer vp)
    {



        //if (videoPlayerT3 != null)
        //{

        //    videoPlayerT3.Play();
        //}
        //T2.SetActive(false);

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

            SceneManager.LoadScene("Take52");
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
