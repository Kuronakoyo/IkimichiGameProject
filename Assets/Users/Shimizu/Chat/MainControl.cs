using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainControl : MonoBehaviour
{

    public int ChatScenecount = 0;
    public GameObject[] GameObjectsTohidden;
    private Transform positionB;
    [SerializeField] public GameObject chatbackground;
    [SerializeField] public GameObject gameObjectsMysken;
    [SerializeField] public GameObject cha1, button1,
    chat2,button2,chat3,button3,chat4,button4,chat5,button5,chat6,button6,chat7,button7,chat8,button8,chat9,button9,chat10,button10,
    button11,chat11, button12, chat12, button13, chat13, button14, chat14, button15, chat15, button16, chat16, button17, chat17,
    button18, chat18, button19, chat19, button20, chat20, button21, chat21, button22, chat22, button23, chat23, button24, chat24, 
    button25, chat25, button26, chat26, button27, chat27,
    Movie1,Moviebutton1,Movie2,Moviebutton2, Movie3, Moviebutton3, Movie4, Moviebutton4, Movie5, Moviebutton5;
    // Start is called before the first frame update
    void Start()
    {
        positionB = chatbackground.GetComponent<Transform>();
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    // Update is called once per frame
    
    public void MovieButton()
    {
        SoundManager.Instance.Play_SE(0, 1);
        Debug.Log("osareta");
        
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
            SoundManager.Instance.Play_SE(0, 5);
        }
        SoundManager.Instance.Play_SE(0, 5);
        //ここに1日目のシーンの名前
        SceneManager.LoadScene("Day1", LoadSceneMode.Additive);
        SoundManager.Instance.Play_SE(0, 5);
    }

    public void MovieButton2()
    {
        
        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
            
        }
        //ここに2日目のシーンの名前
        SceneManager.LoadScene("Day2", LoadSceneMode.Additive);
        
    }

    public void MyskenButton()
    {
        Debug.Log("misuken");
        gameObjectsMysken.SetActive(false);
    }
    public void ChatButton()
    {
        Vector3 pos = positionB.transform.localPosition;
        Debug.Log("chat");

        if (ChatScenecount == 0)
        {
            button1.SetActive(false);
            chat2.SetActive(true);
        }
        if (ChatScenecount == 1)
        {
            button2.SetActive(false);
            chat3.SetActive(true);
        }
        if (ChatScenecount == 2)
        {
            button3.SetActive(false);
            chat4.SetActive(true);
        }
        if (ChatScenecount == 3)
        {
            button4.SetActive(false);
            chat5.SetActive(true);
            pos.y = -6440;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 4)
        {
            button5.SetActive(false);
            chat6.SetActive(true);
            pos.y = -6200;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 5)
        {
            button6.SetActive(false);
            chat7.SetActive(true);
            pos.y = -5930;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 6)
        {
            button7.SetActive(false);
            chat8.SetActive(true);
            pos.y = -5660;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 7)
        {
            button8.SetActive(false);
            chat9.SetActive(true);
            pos.y = -5450;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 8)
        {
            button9.SetActive(false);
            chat10.SetActive(true);
            pos.y = -4760;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 9)
        {
            button10.SetActive(false);
            chat11.SetActive(true);
            pos.y = -4390;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 10)
        {
            button11.SetActive(false);
            chat12.SetActive(true);
            pos.y = -4130;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 11)
        {
            button12.SetActive(false);
            chat13.SetActive(true);
            pos.y = -3820;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 12)
        {
            button13.SetActive(false);
            chat14.SetActive(true);
            pos.y = -3610;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 13)
        {
            button14.SetActive(false);
            chat15.SetActive(true);
            pos.y = -3360;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 14)
        {
            button15.SetActive(false);
            chat16.SetActive(true);
            pos.y = -2990;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 15)
        {
            button16.SetActive(false);
            chat17.SetActive(true);
            pos.y = -2740;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 16)
        {
            button17.SetActive(false);
            chat18.SetActive(true);
            pos.y = -2520;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 17)
        {
            button18.SetActive(false);
            chat19.SetActive(true);
            pos.y = -2260;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 18)
        {
            button19.SetActive(false);
            chat20.SetActive(true);
            pos.y = -2060;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 19)
        {
            button20.SetActive(false);
            chat21.SetActive(true);
            pos.y = -1840;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 20)
        {
            button21.SetActive(false);
            Movie1.SetActive(true);
            pos.y = -1000;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 21)
        {
            Moviebutton1.SetActive(false);
            chat22.SetActive(true);
            pos.y = -1090;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 22)
        {
            button22.SetActive(false);
            Movie2.SetActive(true);
            pos.y = -100;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 23)
        {
            Moviebutton2.SetActive(false);
            chat23.SetActive(true);
            pos.y = -100;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 24)
        {
            Movie3.SetActive(true);
            Moviebutton3.SetActive(true);
            pos.y = 500;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 25)
        {
            Moviebutton3.SetActive(false);
            chat24.SetActive(true);
            button23.SetActive(true);
            pos.y = 1200;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 26)
        {
            button23.SetActive(false);
            Movie4.SetActive(true);
            Moviebutton4.SetActive(true);
            pos.y = 1900;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 27)
        {
            Moviebutton4.SetActive(false);
            Movie5.SetActive(true);
            Moviebutton5.SetActive(true);
            pos.y = 2100;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 28)
        {
            chat25.SetActive(true);
            Moviebutton5.SetActive(true);
            pos.y = 2700;
            positionB.transform.localPosition = pos;
        }
        ChatScenecount++;
    }
    private void OnSceneUnloaded(UnityEngine.SceneManagement.Scene current)
    {
        
        //ここは1日目のシーンの名前
        if(current.name == "Day1")
        {
            foreach(GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //ここは2日目のシーンの名前
        if (current.name == "Day2")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        if (current.name == "Day3")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        if (current.name == "Day4")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        if (current.name == "Day5")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
    }
}
