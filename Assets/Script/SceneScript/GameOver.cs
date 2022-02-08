using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    GameObject button;
    [SerializeField]
    GameObject call_screen;
    [SerializeField]
    GameObject Incoming_call;
    [SerializeField]
    GameObject Crack;
    [SerializeField]
    GameObject callback_end;
    [SerializeField]
    GameObject se;
    [SerializeField]
    GameObject img;
    void Start()
    {
        
    }
    public void Phone()
    {
        StartCoroutine("phone");
        
    }
    IEnumerator phone()
    {
        Destroy(se);
        Incoming_call.SetActive(true);
        SoundManager.Instance.Play_SE(0, 3);
        yield return new WaitForSeconds(13.0f);
        Incoming_call.SetActive(false);
        button.SetActive(false);
        callback_end.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SoundManager.Instance.Play_SE(0, 1);
        Crack.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        call_screen.SetActive(false);
        Crack.SetActive(false);
        callback_end.SetActive(false);
        Incoming_call.SetActive(false);
        img.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        FadeManager.Instance.LoadScene("ToriumiTitle", 2.0f);
    }

        public void OnClickStartButton()
    {
        FadeManager.Instance.LoadScene("", 2.0f);
    }
}
