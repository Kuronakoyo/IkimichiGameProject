using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    //‚±‚êƒƒCƒ“ƒV[ƒ“‚Ì‚Ç‚Á‚©‚É“ü‚ê‚Æ‚¢‚Ä!
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
