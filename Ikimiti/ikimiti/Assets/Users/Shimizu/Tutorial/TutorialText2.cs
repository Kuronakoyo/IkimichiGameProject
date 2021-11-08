using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText2 : MonoBehaviour
{
    [SerializeField]
    List<string> textList = new List<string>();
    [SerializeField]
    Text text;
    [SerializeField]
    float textSpeed;
    int textListIndex = 0;
    private bool NextText = true;
    public TutorialManager tutorialmanager;
    public GameObject manager;
    private bool judge = true;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("flag");
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialmanager.flag2 == true)
        {
            
            if (judge == true)
            {
                text.enabled = true;
                StartCoroutine(Novel());
                judge = false;
            }
            if (Input.GetKey(KeyCode.Space) && !NextText && (textListIndex < textList.Count))
            {
                NextText = true;
                StartCoroutine(Novel());
            }
            else if (Input.GetKey(KeyCode.Space) && !NextText && !(textListIndex < textList.Count))
            {

                manager.GetComponent<TutorialManager>().Flag3();
                Destroy(this.gameObject);
            }
        }
    }
    private IEnumerator Novel()
    {
        int textCount = 0;
        text.text = "";
        while (textList[textListIndex].Length > textCount)
        {
            Debug.Log("a");
            text.text += textList[textListIndex][textCount];
            textCount++;
            yield return new WaitForSeconds(textSpeed);
        }
        textListIndex++;
        NextText = false;
    }
}
