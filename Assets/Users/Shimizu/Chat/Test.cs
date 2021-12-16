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
        SceneManager.UnloadScene("Day1");
    }
}
