using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void OnClickStartButton()
    {
        FadeManager.Instance.LoadScene("TutorialScene", 2.0f);
    }
    public void TutorialButton()
    {
        FadeManager.Instance.LoadScene("SampleScene", 2.0f);
    }

}
