using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    //これメインシーンのどっかに入れといて!
    // Start is called before the first frame update
    public void Testbutton()
    {
        SoundManager.Instance.Play_SE(0, 4);
        SceneManager.UnloadScene("Day1");
    }
    public void Day2btn()
    {
        SceneManager.UnloadScene("Day2");
    }
}
