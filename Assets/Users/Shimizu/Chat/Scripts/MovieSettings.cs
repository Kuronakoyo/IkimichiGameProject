using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovieSettings : MonoBehaviour
{
    private Transform rectBG;
    private GameObject mbutton;
    private void Awake()
    {
        rectBG = GameObject.Find("Chat").GetComponent<Transform>();
        mbutton = GameObject.Find("MButton");
    }
    // Start is called before the first frame update
    void Start()
    {

        mbutton.SetActive(false);
        rectBG.transform.localPosition = new Vector3(0, ChatManager.Instance.chatlocation.Sum() - 155);
        ChatManager.Instance.ChatPreset(1350, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovieGenerate()
    {
        GameObject obj = (GameObject)Resources.Load("movie");
        GameObject instance = (GameObject)Instantiate(obj, new Vector3(0, 332.5f - ChatManager.Instance.chatlocation.Sum(), 0), Quaternion.identity);
        var parent = GameObject.Find("Chat");
        //
        instance.transform.SetParent(parent.transform, false);
    }
}
