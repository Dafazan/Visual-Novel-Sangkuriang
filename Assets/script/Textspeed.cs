using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textspeed : MonoBehaviour
{
    public float speed;

    void Update()
    {
        // Retrieve the saved text speed from PlayerPrefs, defaulting to 0.03 if not set
        speed = PlayerPrefs.GetFloat("textspeed", 0.03f);
    }

    public void Speed1()
    {
        PlayerPrefs.SetFloat("textspeed", 0.03f);
        PlayerPrefs.Save();
    }
    public void Speed2()
    {
        PlayerPrefs.SetFloat("textspeed", 0.01f);
        PlayerPrefs.Save();
    }
    public void Speed3()
    {
        PlayerPrefs.SetFloat("textspeed", 0.008f);
        PlayerPrefs.Save();
    }
}
