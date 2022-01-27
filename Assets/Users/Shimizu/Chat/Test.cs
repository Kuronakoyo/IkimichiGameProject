using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    //‚±‚êƒƒCƒ“ƒV[ƒ“‚Ì‚Ç‚Á‚©‚É“ü‚ê‚Æ‚¢‚Ä!
    // Start is called before the first frame update
    public void Day1button()
    {
         SceneManager.UnloadScene("Day1");
    }

    public void Day2button()
    {
        SceneManager.UnloadScene("Day2");
    }
    public void Day3button()
    {
        SceneManager.UnloadScene("Day3");
    }
    public void Day4button()
    {
        SceneManager.UnloadScene("Day4");
    }
    public void Day5button()
    {
        SceneManager.UnloadScene("Day5");
    }
}
