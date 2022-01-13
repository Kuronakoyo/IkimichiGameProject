using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ChatSettings : MonoBehaviour
{
    private Text textUI;
    private RectTransform rect;
    [SerializeField]private Image imgUI;
    private Transform rectBG;
    private bool judge = true;
    private float pass = 200;
    private float pass2 = 0;
    private bool my = false;
    [SerializeField] GameObject hito1;
    [SerializeField] GameObject hito1text;
    [SerializeField] GameObject hito2;
    [SerializeField] GameObject hito2text;
    [SerializeField] GameObject hito3;
    [SerializeField] GameObject hito3text;
    [SerializeField] GameObject hito4;
    [SerializeField] GameObject hito4text;
    [SerializeField] GameObject mychat;
    
    GameObject hito;

    [SerializeField] List<string> chatList = new List<string>();



    private void Awake()
    {
        textUI = transform.Find("chatText").GetComponent<Text>();
        rect = GetComponent<RectTransform>();
        rectBG = GameObject.Find("Chat").GetComponent<Transform>();
        

    }
    private void Start()
    {
        if(ChatManager.Instance.chatIndex == 0 || 
            ChatManager.Instance.chatIndex == 3 ||
            ChatManager.Instance.chatIndex == 8 ||
            ChatManager.Instance.chatIndex == 12 ||
            ChatManager.Instance.chatIndex == 14 ||
            ChatManager.Instance.chatIndex == 16 ||
            ChatManager.Instance.chatIndex == 19 )
        {
            hito1.SetActive(true);
            hito = hito1;
        }
        if (ChatManager.Instance.chatIndex == 4 ||
            ChatManager.Instance.chatIndex == 6 ||
            ChatManager.Instance.chatIndex == 9 ||
            ChatManager.Instance.chatIndex == 13 ||
            ChatManager.Instance.chatIndex == 15 ||
            ChatManager.Instance.chatIndex == 20 ||
            ChatManager.Instance.chatIndex == 21 ||
            ChatManager.Instance.chatIndex == 22 ||
            ChatManager.Instance.chatIndex == 23 ||
            ChatManager.Instance.chatIndex == 24 ||
            ChatManager.Instance.chatIndex == 25 )
        {
            hito2.SetActive(true);
            hito = hito2;
        }
        if (ChatManager.Instance.chatIndex == 1 ||
            ChatManager.Instance.chatIndex == 5 ||
            ChatManager.Instance.chatIndex == 7 ||
            ChatManager.Instance.chatIndex == 11 ||
            ChatManager.Instance.chatIndex == 17 )
        {
            hito3.SetActive(true);
            hito = hito3;
        }
        if (ChatManager.Instance.chatIndex == 2 ||
            ChatManager.Instance.chatIndex == 10 ||
            ChatManager.Instance.chatIndex == 18 )
        {
            //ここにメッセージ反転かな
            imgUI = this.gameObject.GetComponent<Image>();

            //これ↓なぞにエラー吐く、シリアライズフィールドでもimgにImage設定できなかったけどなぜ
            //imgUI.enabled = false;

            mychat.SetActive(true);
            //rect = transform.Find("mychat").GetComponent<RectTransform>();
            my = true;
            //
            hito4.SetActive(true);
            hito = hito4;
        }
        if (judge)
        {
            //一行
            if (chatList[ChatManager.Instance.chatIndex].Length < 13)
            {
                
                rectBG.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 1355);
                //if(my)
                //{
                //     var rectmy = transform.Find("mychat").GetComponent<RectTransform>();
                //     rectmy.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 1355);
                //}
            }
            //二行
            if (chatList[ChatManager.Instance.chatIndex].Length > 12 && chatList[ChatManager.Instance.chatIndex].Length < 25)
            {
                rect.sizeDelta = new Vector2(800, 285);
                rect.localPosition -= new Vector3(0,42.5f);
                hito.transform.localPosition += new Vector3(0, 25);
                rectBG.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 1270);
                pass = 285;
                pass2 = 42.5f;
                if (my)
                {
                    var rectmy = transform.Find("mychat").GetComponent<RectTransform>();
                    rectmy.sizeDelta = new Vector2(800, 285);
                    //rectmy.localPosition -= new Vector3(0, 42.5f);
                }
            }
            //三行
            if (chatList[ChatManager.Instance.chatIndex].Length > 24 && chatList[ChatManager.Instance.chatIndex].Length < 37)
            {
                rect.sizeDelta = new Vector2(800, 370);
                rect.localPosition -= new Vector3(0, 85);
                hito.transform.localPosition += new Vector3(0, 50);
                rectBG.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 1185);
                pass = 370;
                pass2 = 85;
                if (my)
                {
                    var rectmy = transform.Find("mychat").GetComponent<RectTransform>();
                    rectmy.sizeDelta = new Vector2(800, 370);
                    //rectmy.localPosition -= new Vector3(0, 85);

                }
            }
            //四行
            if (chatList[ChatManager.Instance.chatIndex].Length > 36 && chatList[ChatManager.Instance.chatIndex].Length < 49)
            {
                rect.sizeDelta = new Vector2(800, 455);
                rect.localPosition -= new Vector3(0, 122.5f);
                hito.transform.localPosition += new Vector3(0, 75);
                rectBG.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 1100);
                pass = 455;
                pass2 = 122.5f;
                if (my)
                {
                    var rectmy = transform.Find("mychat").GetComponent<RectTransform>();
                    rectmy.sizeDelta = new Vector2(800, 455);
                    //rectmy.localPosition -= new Vector3(0, 122.5f);
                }
            }
            //五行
            if (chatList[ChatManager.Instance.chatIndex].Length > 48 && chatList[ChatManager.Instance.chatIndex].Length < 61)
            {
                rect.sizeDelta = new Vector2(800, 540);
                rect.localPosition -= new Vector3(0, 170);
                hito.transform.localPosition += new Vector3(0, 100);
                rectBG.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 1015);
                pass = 540;
                pass2 = 170;
                if (my)
                {
                    var rectmy = transform.Find("mychat").GetComponent<RectTransform>();
                    rectmy.sizeDelta = new Vector2(800, 540);
                    //rectmy.localPosition -= new Vector3(0, 170);
                }
            }
            //六行
            if (chatList[ChatManager.Instance.chatIndex].Length > 60 && chatList[ChatManager.Instance.chatIndex].Length < 73)
            {
                rect.sizeDelta = new Vector2(800, 625);
                rect.localPosition -= new Vector3(0, 212.5f);
                hito.transform.localPosition += new Vector3(0, 125);
                rectBG.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 930);
                pass = 540;
                pass2 = 212.5f;
                if (my)
                {
                    var rectmy = transform.Find("mychat").GetComponent<RectTransform>();
                    rectmy.sizeDelta = new Vector2(800, 625);
                    //rectmy.localPosition -= new Vector3(0, 212.5f);
                }
            }
            //テキスト挿入
            textUI.text = chatList[ChatManager.Instance.chatIndex];
            

            ChatManager.Instance.ChatPreset(pass,pass2);
        }
        judge = false;
    }
    public void ChatGenerate()
    {
        Debug.Log(ChatManager.Instance.chatIndex);
        //プレハブ取得
        GameObject obj = (GameObject)Resources.Load("chat");
        //プレハブからオブジェクトを生成
        GameObject instance = (GameObject)Instantiate(obj, new Vector3(0, 620 - ChatManager.Instance.chatlocation.Sum(), 0), Quaternion.identity);
        //
        var parent = GameObject.Find("Chat");
        //
        instance.transform.SetParent(parent.transform, false);
        //カメラ移動処理

    }
   
}
