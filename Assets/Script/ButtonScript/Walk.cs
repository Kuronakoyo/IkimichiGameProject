using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public MoveButton mb;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void playwalk()
    {
        mb.ChangeBackground();
    }
   
}
