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
        SceneManager.UnloadScene("Day1");
    }
}
