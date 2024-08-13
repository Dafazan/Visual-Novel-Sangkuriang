using UnityEngine;
using UnityEngine.SceneManagement;

public class Saver : MonoBehaviour
{
    public string scene;
    public GameObject panelnotice;

    void Update()
    {
        scene = PlayerPrefs.GetString("saved", "SampleScene");
    }

    public void Gotoscene()
    {
        if (scene == "")
        {
            panelnotice.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
     
    }

   
    public void SetSceneStarting()
    {
        PlayerPrefs.SetString("saved", "Starting");
        PlayerPrefs.Save();
    }
    public void SetSceneT1()
    {
        PlayerPrefs.SetString("saved", "Take 1");
        PlayerPrefs.Save();
    }
    public void SetSceneT2()
    {
        PlayerPrefs.SetString("saved", "Take2");
        PlayerPrefs.Save();
    }
    public void SetSceneT3()
    {
        PlayerPrefs.SetString("saved", "Take3");
        PlayerPrefs.Save();
    }
    public void SetSceneT41()
    {
        PlayerPrefs.SetString("saved", "Take41");
        PlayerPrefs.Save();
    }
    public void SetSceneT5()
    {
        PlayerPrefs.SetString("saved", "Take5");
        PlayerPrefs.Save();
    }
    public void SetSceneT4()
    {
        PlayerPrefs.SetString("saved", "Take4");
        PlayerPrefs.Save();
    }
    public void SetSceneT51()
    {
        PlayerPrefs.SetString("saved", "Take51");
        PlayerPrefs.Save();
    }
    public void SetSceneT52()
    {
        PlayerPrefs.SetString("saved", "Take52");
        PlayerPrefs.Save();
    }
    public void SetSceneT53()
    {
        PlayerPrefs.SetString("saved", "Take53");
        PlayerPrefs.Save();
    }
    public void SetSceneT54()
    {
        PlayerPrefs.SetString("saved", "Take54");
        PlayerPrefs.Save();
    }
    public void SetSceneT55()
    {
        PlayerPrefs.SetString("saved", "Take55");
        PlayerPrefs.Save();
    }



    public void XSetSceneStarting()
    {
        PlayerPrefs.SetString("saved", "Starting");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT1()
    {
        PlayerPrefs.SetString("saved", "Take 1");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT2()
    {
        PlayerPrefs.SetString("saved", "Take2");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT3()
    {
        PlayerPrefs.SetString("saved", "Take3");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT41()
    {
        PlayerPrefs.SetString("saved", "Take41");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT5()
    {
        PlayerPrefs.SetString("saved", "Take5");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT4()
    {
        PlayerPrefs.SetString("saved", "Take4");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT51()
    {
        PlayerPrefs.SetString("saved", "Take51");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT52()
    {
        PlayerPrefs.SetString("saved", "Take52");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT53()
    {
        PlayerPrefs.SetString("saved", "Take53");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT54()
    {
        PlayerPrefs.SetString("saved", "Take54");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    public void XSetSceneT55()
    {
        PlayerPrefs.SetString("saved", "Take55");
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
}
