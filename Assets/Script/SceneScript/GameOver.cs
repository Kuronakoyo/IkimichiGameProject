using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void OnClickStartButton()
    {
        FadeManager.Instance.LoadScene("Start", 2.0f);
    }
}
