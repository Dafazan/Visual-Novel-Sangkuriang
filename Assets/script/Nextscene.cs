using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextscene : MonoBehaviour
{

    public int state;
    public GameObject skipage;

    void Start()
    {
        state = PlayerPrefs.GetInt("finish");
        if (state == 0)
        {
            skipage.SetActive(false);
        } else if (state == 1)
        {
            skipage.SetActive(true);
        }
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("finish", 0);
        PlayerPrefs.Save();
    }

    public void Skip()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Prev()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
