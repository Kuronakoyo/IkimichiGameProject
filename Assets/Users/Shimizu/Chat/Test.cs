using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    //���ꃁ�C���V�[���̂ǂ����ɓ���Ƃ���!
    // Start is called before the first frame update
    public void day1button()
    {
        SceneManager.UnloadScene("Day1");
    }
    public void day2button()
    {
        SceneManager.UnloadScene("Day2");
    }
    public void day3button()
    {
        SceneManager.UnloadScene("Day3");
    }
    public void day4button()
    {
        SceneManager.UnloadScene("Day4");
    }
    public void day5button()
    {
        SceneManager.UnloadScene("Day5");
    }
}
