using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private bool judge = true;
    private Text movefront;
    private Image image;
    private Button button;
    public TutorialManager tutorialmanager;
    public GameObject manager;
    public Image smallcat;
    public Image backcat;
    private void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        movefront = transform.Find("MoveFront").GetComponent<Text>();
        smallcat = GameObject.Find("smallcat").GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("flag");
    }

    // Update is called once per frame
    void Update()
    {
        if(tutorialmanager.flag1 == true && judge == true)
        {
            image.enabled = true;
            button.enabled = true;
            movefront.enabled = true;
            judge = false;
        }
    }
    public void Click()
    {
        smallcat.enabled = true;
        manager.GetComponent<TutorialManager>().Flag2();
        Destroy(this.gameObject);
    }
}
