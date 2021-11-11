using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBack : MonoBehaviour
{
    public GameObject cat;
    public GameObject blackcat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackOnclick()
    {
        if(cat == true && blackcat == true)
        {
            cat.SetActive(false);
            blackcat.SetActive(false);
        }
    }
}
