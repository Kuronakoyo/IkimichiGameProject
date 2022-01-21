using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Walk : MonoBehaviour
{
    [SerializeField]
    private Button walkbtn;
    [SerializeField]
    private Button runbtn;
    [SerializeField]
    private Button movebtn;
    public MoveButton mb;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void playwalk()
    {
        mb.ChangeBackground();
    
        StartCoroutine(ButtonOn());
    }
    IEnumerator ButtonOn()
    {
        yield return new WaitForSeconds(1.8f);
        movebtn.interactable = true;
        walkbtn.interactable = true;
        if (mb.runbtncount == 0)
        {
            runbtn.interactable = false;
        }
        else
        {
            runbtn.interactable = true;
        }
    }

}
