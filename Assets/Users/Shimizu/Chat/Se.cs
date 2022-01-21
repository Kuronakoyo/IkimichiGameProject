using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Se : MonoBehaviour
{
    public void se_chat()
    {
        SoundManager.Instance.Play_SE(0, 0);
    }
    public void se_movie()
    {
        SoundManager.Instance.Play_SE(0, 1);
    }
    public void se_notice()
    {
        SoundManager.Instance.Play_SE(0, 2);
    }
}
