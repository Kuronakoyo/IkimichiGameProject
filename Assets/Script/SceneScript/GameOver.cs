using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void OnClickStartButton()
    {
        FadeManager.Instance.LoadScene("", 2.0f);
    }
}
