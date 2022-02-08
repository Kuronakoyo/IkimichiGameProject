using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_FadeOut : MonoBehaviour
{
    [SerializeField]
    GameObject _fade;

    [SerializeField]
    GameObject _callscreen;

    Animator _anim;


    void Start()
    {
        _anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        StartCoroutine("GameOverEnd");
    }

    IEnumerator GameOverEnd()
    {
        _anim.SetBool("OutFlag", true);

        // 1�b��(�A�j���[�V������)
        yield return new WaitForSeconds(1.0f);
        Debug.Log("1");

        // 3�b��
        yield return new WaitForSeconds(3.0f);
        Debug.Log("2");

        // ���M��������

        // ���M��ʂ�\��
        _callscreen.SetActive(true);
    }
}
