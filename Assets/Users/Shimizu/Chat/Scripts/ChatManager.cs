using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public static ChatManager Instance { get => _instance; }
    static ChatManager _instance;

    public GameObject[] GameObjectsTohidden;
    public GameObject can;
    [SerializeField] GameObject cbutton;
    [SerializeField] GameObject mbutton;
    public List<float> chatlocation = new List<float>();
    public int chatIndex = 0;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        
    }
    void Start()
    {
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }
    public void ChatPreset(float num , float num2)
    {
        chatlocation.Add(num/2 + num2 + 80);
        if(chatIndex == 20)
        {
            cbutton.SetActive(false);
            mbutton.SetActive(true);
        }
             chatIndex++;
    }

    //������setactive(false)���@�\���Ȃ�
    public void MovieButton()
    {
        Debug.Log("osareta");
        
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        
        //������1���ڂ̃V�[���̖��O
        SceneManager.LoadScene("Day1", LoadSceneMode.Additive);
    }
    public void MovieButton2()
    {

        Debug.Log("osareta");
        can = GameObject.Find("Canvas");
        Debug.Log(can);
        can.SetActive(false);
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //������2���ڂ̃V�[���̖��O
        SceneManager.LoadScene("Day2", LoadSceneMode.Additive);
    }
    public void MovieButton3()
    {

        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //������3���ڂ̃V�[���̖��O
        SceneManager.LoadScene("Day3", LoadSceneMode.Additive);
    }
    public void MovieButton4()
    {

        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //������4���ڂ̃V�[���̖��O
        SceneManager.LoadScene("Day4", LoadSceneMode.Additive);
    }
    public void MovieButton5()
    {

        Debug.Log("osareta");
        foreach (GameObject obj in GameObjectsTohidden)
        {
            obj.SetActive(false);
        }
        //������5���ڂ̃V�[���̖��O
        SceneManager.LoadScene("Day5", LoadSceneMode.Additive);
    }
    private void OnSceneUnloaded(UnityEngine.SceneManagement.Scene current)
    {

        //������1���ڂ̃V�[���̖��O
        if (current.name == "Day1")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //������2���ڂ̃V�[���̖��O
        if (current.name == "Day2")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //3
        if (current.name == "Day3")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //4
        if (current.name == "Day4")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }
        //5
        if (current.name == "Day5")
        {
            foreach (GameObject obj in GameObjectsTohidden)
            {
                obj.SetActive(true);
            }
        }

    }

}
