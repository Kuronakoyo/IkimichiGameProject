using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    //���ꃁ�C���V�[���̂ǂ����ɓ���Ƃ���!
    // Start is called before the first frame update
    public void Testbutton()
    {
        SceneManager.UnloadScene("Day1");
    }
}
