using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pagecontol : MonoBehaviour
{
    // Panel
    [SerializeField] GameObject MainPanel;
    [SerializeField] GameObject SettingsPanel;
    [SerializeField] GameObject PausePanel;
    [SerializeField] GameObject ExitPanel;
    [SerializeField] GameObject NoticeContinuePanel;

    // Button
    [SerializeField] GameObject PauseBtn;
    [SerializeField] GameObject ContinueBtn;
    [SerializeField] GameObject Skipbtn;

    // Boolean
    bool isSaved = false;


    //Opening Panel
    public void PlayStory()
    {
        MainPanel.SetActive(false);
        PauseBtn.SetActive(true);
        ContinueBtn.SetActive(false);
        NoticeContinuePanel.SetActive(false);
        Skipbtn.SetActive(true);
    }
    public void Settings()
    {
        SettingsPanel.SetActive(true);
        PauseBtn.SetActive(false);
        ContinueBtn.SetActive(true);
        Skipbtn.SetActive(false);
    }
    public void SettingsMain()
    {
        SettingsPanel.SetActive(true);
        Skipbtn.SetActive(false);
    }
    public void BackMainMenu()
    {
        MainPanel.SetActive(true);
        SettingsPanel.SetActive(false);
        PauseBtn.SetActive(false);
        ContinueBtn.SetActive(false);
        PausePanel.SetActive(false);
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        PauseBtn.SetActive(false);
        ContinueBtn.SetActive(true);
        Skipbtn.SetActive(false);
    }
    public void Exit()
    {
        ExitPanel.SetActive(true);
        PauseBtn.SetActive(false);
        ContinueBtn.SetActive(true);
    }
    public void ExitConfirm()
    {
        ExitPanel.SetActive(false);
        MainPanel.SetActive(false);
    }
    public void Notice()
    {
        NoticeContinuePanel.SetActive(true);
        Skipbtn.SetActive(false);
    }

    //Closing Panel
    public void XSettings()
    {
        SettingsPanel.SetActive(false);
        Skipbtn.SetActive(true);
    }
    public void XPause()
    {
        PausePanel.SetActive(false);
        PauseBtn.SetActive(true);
        ContinueBtn.SetActive(false);
        SettingsPanel.SetActive(false);
        Skipbtn.SetActive(true);
    }

    public void XExit()
    {
        ExitPanel.SetActive(false);
        PauseBtn.SetActive(true);
        ContinueBtn.SetActive(false);
        Skipbtn.SetActive(true);
    }
    public void XNotice()
    {
        NoticeContinuePanel.SetActive(false);
        Skipbtn.SetActive(true);
    }

    // General Function
   

}
