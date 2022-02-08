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

        // 1秒後(アニメーション分)
        yield return new WaitForSeconds(1.0f);
        Debug.Log("1");

        // 3秒後
        yield return new WaitForSeconds(3.0f);
        Debug.Log("2");

        // 着信音を入れる

        // 着信画面を表示
        _callscreen.SetActive(true);
    }
}
