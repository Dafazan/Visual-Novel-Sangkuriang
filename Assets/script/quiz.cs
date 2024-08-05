using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quiz : MonoBehaviour
{

    public GameObject startpanel;
    public GameObject wrongpanel;
    public GameObject q1;
    public GameObject q2;
    public GameObject q3;
    public GameObject nicepanel;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void quizinvalid()
    {
        wrongpanel.SetActive(true);
    }
    public void retryin()
    {
        wrongpanel.SetActive(false);
    }
    public void retry()
    {
        wrongpanel.SetActive(false);
        SceneManager.LoadScene("QuizPart");
    }
    public void continuequiz()
    {
        startpanel.SetActive(false);
        q1.SetActive(true);
    }
    public void correct1()
    {
        q1.SetActive(false);
        q2.SetActive(true);
    }
    public void correct2()
    {
        q2.SetActive(false);
        q3.SetActive(true);
    }
    public void correct3()
    {
        q3.SetActive(false);
        nicepanel.SetActive(true);
    }
    public void menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
