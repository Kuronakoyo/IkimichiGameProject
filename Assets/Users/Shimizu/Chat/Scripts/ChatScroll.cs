using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ChatScroll : MonoBehaviour
{
    private float scroll;
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        //rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        scroll = Input.GetAxis("Mouse ScrollWheel");
        //Debug.Log(ChatManager.Instance.chatlocation.Sum());
        pos.y = transform.localPosition.y - scroll * speed;
        //上の限界
        if (pos.y < 0)
        {
            pos.y = 0;
        }
        //チャット量少数時の下の限界
        if (0 < pos.y && ChatManager.Instance.chatIndex < 6)
        {
            pos.y = 0;
        }
        //スクロールできるようになったあとの下の限界
        if (ChatManager.Instance.chatlocation.Sum() -1555 < pos.y && ChatManager.Instance.chatIndex > 5)
        {
            pos.y = ChatManager.Instance.chatlocation.Sum() -1555;
            
        }
        transform.localPosition = pos;
    }
}
