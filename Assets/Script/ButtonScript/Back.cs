using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    public BrackCat bc;
  public void back_click()
    {
        if(bc.gameObject.activeInHierarchy == true)
        {
            bc.gameObject.SetActive(false);
        }
    }
}
