using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncomingCall : MonoBehaviour
{
    [SerializeField]
    GameObject _bg;

    [SerializeField]
    GameObject _gameover;

    [SerializeField]
    GameObject _callscreen;

    [SerializeField]
    GameObject _panel;

    [SerializeField]
    GameObject _panel2;

    [SerializeField]
    GameObject _title;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Incoming()
    {
        StartCoroutine("incoming");
    }

    IEnumerator incoming()
    {
        SoundManager.Instance.Stop_SE(0, 0);
        // 着信画面を非表示(黒の画像を被せている)
        _bg.SetActive(true);

        // 2秒後
        yield return new WaitForSeconds(2.0f);

        // 文字『次はお前だ』
        Debug.Log("次はお前だ");     // 借り入れ
        _panel2.SetActive(true);
        // SE   砂嵐
        SoundManager.Instance.Play_SE(0, 1);

        // 3秒後(時間遅めでもいいと思う)
        yield return new WaitForSeconds(5.0f);

        // 全部の画面を非表示
        _bg.SetActive(false);
        _gameover.SetActive(false);
        _panel.SetActive(false);
        _panel2.SetActive(false);
        _callscreen.SetActive(false);

        // タイトル画面(GameOver用)を表示
        _title.SetActive(true);
        
        FadeManager.Instance.LoadScene("ToriumiTitle", 7.0f);
    }


}
