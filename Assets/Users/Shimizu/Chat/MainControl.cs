using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainControl : MonoBehaviour
{
<<<<<<< HEAD

    public int ChatScenecount = 0;
=======
    private int count = 0;
>>>>>>> Nakasyouji
    public GameObject[] GameObjectsTohidden;
    [SerializeField] public GameObject gameObjectsMysken;
    [SerializeField] public GameObject cha1, button1;
    [SerializeField] public GameObject chat2,button2;
    [SerializeField] public GameObject chat3,button3;
    [SerializeField] public GameObject chat4,button4;
    [SerializeField] public GameObject chat5,button5;
<<<<<<< HEAD
    [SerializeField] public GameObject chat6,button6;
    [SerializeField] public GameObject chat7,button7;
    [SerializeField] public GameObject chat8,button8;
    [SerializeField] public GameObject Movie1,Moviebutton1;
    [SerializeField] public GameObject Movie2,Moviebutton2;
=======
>>>>>>> Nakasyouji
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

<<<<<<< HEAD
        if (ChatScenecount == 0)
=======
        if (count == 0)
>>>>>>> Nakasyouji
        {
            button1.SetActive(false);
            chat2.SetActive(true);
            
        }
<<<<<<< HEAD
        if (ChatScenecount == 1)
=======
        if (count == 1)
>>>>>>> Nakasyouji
        {
            button2.SetActive(false);
            chat3.SetActive(true);
        }
<<<<<<< HEAD
        if (ChatScenecount == 2)
=======
        if (count == 2)
>>>>>>> Nakasyouji
        {
            button3.SetActive(false);
            chat4.SetActive(true);
        }
<<<<<<< HEAD
        if (ChatScenecount == 3)
=======
        if (count == 3)
>>>>>>> Nakasyouji
        {
            button4.SetActive(false);
            chat5.SetActive(true);
        }
<<<<<<< HEAD
        if (ChatScenecount == 4)
        {
            button5.SetActive(false);
            chat6.SetActive(true);
        }
        if (ChatScenecount == 5)
        {
            button6.SetActive(false);
            chat7.SetActive(true);
        }
        if (ChatScenecount == 6)
        {
            button7.SetActive(false);
            chat8.SetActive(true);
        }
        if (ChatScenecount == 7)
        {
            button8.SetActive(false);
            Movie1.SetActive(true);
        }
        if (ChatScenecount == 8)
        {
            Moviebutton1.SetActive(false);
            Movie2.SetActive(true);
        }
        ChatScenecount++;
=======
        count++;
>>>>>>> Nakasyouji
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
        if (current.name == "SecondScene")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
    }
}
