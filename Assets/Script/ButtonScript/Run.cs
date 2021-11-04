using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public MoveButton mb;
    private Animator anim;
    private int ButtonCount;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ButtonCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Run_click()
    {
        ButtonCount--;
        anim.SetInteger("Count", ButtonCount);
        mb.ChangeBackground();
    }
}
