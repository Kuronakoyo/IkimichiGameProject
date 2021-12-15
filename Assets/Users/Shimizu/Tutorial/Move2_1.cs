using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//1a
public class Move2_1 : MonoBehaviour
{
    private bool judge = true;
    private bool judge2 = true;
    private Image image;
    private Button button;
    public TutorialManager tutorialmanager;
    public Image cat;
    public Image smallcat;
    private void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        cat = GameObject.Find("cat").GetComponent<Image>();
        smallcat = GameObject.Find("smallcat").GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialmanager.flag3 == true && judge == true)
        {
            image.enabled = true;
            button.enabled = true;
            judge = false;
        }
    }
    public void Click()
    {
        if(judge2== true)
        { 
            cat.enabled = true;
            smallcat.enabled = false;
            tutorialmanager.GetComponent<TutorialManager>().Flag4();
            tutorialmanager.GetComponent<TutorialManager>().Flag6();
            judge2 = false;
        }
    }
}
