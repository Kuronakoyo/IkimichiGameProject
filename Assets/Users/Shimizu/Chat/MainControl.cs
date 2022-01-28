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
    button18, chat18, button19, chat19, button20, chat20, button21, chat21, button22, chat22, button23, chat23,
    chat24, button24, chat25, button25, chat26, button26, chat27, button27, chat28, button28, chat29, button29, chat30, button30, chat31, button31, chat32, button32,
    chat33,button33, chat34, button34, chat35, button35, chat36, button36, chat37, button37, chat38, button38, chat39, button39, 
    chat40,button40, chat41, button41, chat42, button42, chat43, button43, chat44, button44, chat45, button45, chat46, button46, chat47, button47, chat48, button48, chat49, button49,
    Movie1,Moviebutton1,Movie2,Moviebutton2, Movie3, Moviebutton3, Movie4, Moviebutton4, Movie5, Moviebutton5;
    // Start is called before the first frame update
    void Start()
    {
        positionB = chatbackground.GetComponent<Transform>();
        SceneManager.sceneUnloaded += OnSceneUnloaded;
        SoundManager.Instance.Play_SE(0, 0);
    }

    // Update is called once per frame
    
    public void MovieButton()
    {
        Debug.Log("osareta");
        foreach(GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //ここに1日目のシーンの名前
        SceneManager.LoadScene("Day1", LoadSceneMode.Additive);
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
    public void MovieButton3()
    {

        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //ここに3日目のシーンの名前
        SceneManager.LoadScene("Day3", LoadSceneMode.Additive);
    }
    public void MovieButton4()
    {

        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //ここに2日目のシーンの名前
        SceneManager.LoadScene("Day4", LoadSceneMode.Additive);
    }
    public void MovieButton5()
    {

        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //ここに2日目のシーンの名前
        SceneManager.LoadScene("Day5", LoadSceneMode.Additive);
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
            //Moviebutton1.SetActive(false);
            pos.y = -1070;
            positionB.transform.localPosition = pos;
            ChatScenecount++;
        }
        if (ChatScenecount == 21)
        {
            Moviebutton1.SetActive(false);
            chat22.SetActive(true);
            pos.y = -850;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 22)
        {
            button22.SetActive(false);
            chat23.SetActive(true);
            pos.y = -520;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 23)
        {
            button23.SetActive(false);
            chat24.SetActive(true);
            pos.y = -320;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 24)
        {
            button24.SetActive(false);
            chat25.SetActive(true);
            pos.y = -90;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 25)
        {
            button25.SetActive(false);
            chat26.SetActive(true);
            //button26.SetActive(false);
            Moviebutton1.SetActive(true);
            pos.y = 130;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 26)
        {
            //button26.SetActive(false);
            Movie2.SetActive(true);
            pos.y = 910;
            positionB.transform.localPosition = pos;
            ChatScenecount++;
        }
        if (ChatScenecount == 27)
        {
            Moviebutton2.SetActive(false);
            chat27.SetActive(true);
            pos.y = 1185;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 28)
        {
            button27.SetActive(false);
            chat28.SetActive(true);
            pos.y = 1485;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 29)
        {
            button28.SetActive(false);
            chat29.SetActive(true);
            pos.y = 1730;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 30)
        {
            button29.SetActive(false);
            chat30.SetActive(true);
            pos.y = 1940;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 31)
        {
            button30.SetActive(false);
            chat31.SetActive(true);
            Moviebutton2.SetActive(true);
            pos.y = 2210;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 32)
        {
            button31.SetActive(false);
            Movie3.SetActive(true);
            
            pos.y = 2990;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 33)
        {
            Moviebutton3.SetActive(false);
            chat32.SetActive(true);
            pos.y = 3300;
            positionB.transform.localPosition = pos;
            ChatScenecount++;
        }
        if (ChatScenecount == 34)
        {
            button32.SetActive(false);
            chat33.SetActive(true);
            pos.y = 3560;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 35)
        {
            button33.SetActive(false);
            chat34.SetActive(true);
            pos.y = 3810;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 36)
        {
            button34.SetActive(false);
            chat35.SetActive(true);
            pos.y = 4160;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 37)
        {
            button35.SetActive(false);
            chat36.SetActive(true);
            pos.y = 4380;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 38)
        {
            button36.SetActive(false);
            chat37.SetActive(true);
            Moviebutton3.SetActive(true);
            pos.y = 4660;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 39)
        {
            button37.SetActive(false);
            Movie4.SetActive(true);
            pos.y = 5440;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 40)
        {
            Moviebutton4.SetActive(false);
            chat38.SetActive(true);
            pos.y = 5665;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 41)
        {
            button38.SetActive(false);
            chat39.SetActive(true);
            pos.y = 6040;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 42)
        {
            button39.SetActive(false);
            chat40.SetActive(true);
            pos.y = 6360;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 43)
        {
            button40.SetActive(false);
            chat41.SetActive(true);
            pos.y = 6620;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 44)
        {
            button41.SetActive(false);
            chat42.SetActive(true);
            Moviebutton4.SetActive(true);
            //pos.y = 6875;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 45)
        {
            button42.SetActive(false);
            Movie5.SetActive(true);
            pos.y = 7625;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 46)
        {
            Moviebutton5.SetActive(false);
            chat43.SetActive(true);
            pos.y = 8045;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 47)
        {
            button43.SetActive(false);
            chat44.SetActive(true);
            pos.y = 8345;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 48)
        {
            button44.SetActive(false);
            chat45.SetActive(true);
            pos.y = 8600;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 49)
        {
            button45.SetActive(false);
            chat46.SetActive(true);
            pos.y = 8850;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 50)
        {
            button46.SetActive(false);
            chat47.SetActive(true);
            pos.y = 9050;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 51)
        {
            button47.SetActive(false);
            chat48.SetActive(true);
            pos.y = 9530;
            positionB.transform.localPosition = pos;
        }
        if (ChatScenecount == 52)
        {
            button48.SetActive(false);
            chat49.SetActive(true);
            Moviebutton5.SetActive(true);
            pos.y = 9780;
            positionB.transform.localPosition = pos;
        }
        //42
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
        //ここは2日目のシーンの名前
        if (current.name == "Day3")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //ここは2日目のシーンの名前
        if (current.name == "Day4")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //ここは2日目のシーンの名前
        if (current.name == "Day5")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
    }
}
