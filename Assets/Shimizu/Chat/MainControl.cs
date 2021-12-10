using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainControl : MonoBehaviour
{
    private int count = 0;
    public GameObject[] GameObjectsTohidden;
    [SerializeField] public GameObject gameObjectsMysken;
    [SerializeField] public GameObject cha1, button1;
    [SerializeField] public GameObject chat2,button2;
    [SerializeField] public GameObject chat3,button3;
    [SerializeField] public GameObject chat4,button4;
    [SerializeField] public GameObject chat5,button5;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneUnloaded += OnSceneUnloaded;
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
        SceneManager.LoadScene("SubScene", LoadSceneMode.Additive);
    }

    public void MovieButton2()
    {
        
        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //ここに2日目のシーンの名前
        SceneManager.LoadScene("SecondScene", LoadSceneMode.Additive);
    }

    public void MyskenButton()
    {
        Debug.Log("misuken");
        gameObjectsMysken.SetActive(false);
    }
    public void ChatButton()
    {
        Debug.Log("chat");

        if (count == 0)
        {
            button1.SetActive(false);
            chat2.SetActive(true);
            
        }
        if (count == 1)
        {
            button2.SetActive(false);
            chat3.SetActive(true);
        }
        if (count == 2)
        {
            button3.SetActive(false);
            chat4.SetActive(true);
        }
        if (count == 3)
        {
            button4.SetActive(false);
            chat5.SetActive(true);
        }
        count++;
    }
    private void OnSceneUnloaded(Scene current)
    {
        
        //ここは1日目のシーンの名前
        if(current.name == "SubScene")
        {
            foreach(GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //ここは2日目のシーンの名前
        if (current.name == "SecondScene")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
    }
}
