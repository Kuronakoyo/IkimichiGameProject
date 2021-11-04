using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityGauge : MonoBehaviour
{
    [SerializeField]
    private float enemy1;
    [SerializeField]
    private float enemy2;
    [SerializeField]
    private float enemy3;
    [SerializeField]
    private float enemy4;
    [SerializeField]
    private float enemy5;
    private float gauge = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   /* void Update()
    {
        //d—l‚ªã‚ª‚Á‚Ä—ˆŸ‘æ’Ç‰ÁEC³
        if (true)
        {
            Debug.Log("a");
           GetComponent<Image>().fillAmount = gauge - enemy1;
            gauge = GetComponent<Image>().fillAmount;
        }
        if (true)
        {
            Debug.Log("b");
            GetComponent<Image>().fillAmount = gauge - enemy2;
            gauge = GetComponent<Image>().fillAmount;
        }
        if (true)
        {
            Debug.Log("c");
            GetComponent<Image>().fillAmount = gauge - enemy3;
            gauge = GetComponent<Image>().fillAmount;
        }
        if (true)
        {
            Debug.Log("d");
            GetComponent<Image>().fillAmount = gauge - enemy4;
            gauge = GetComponent<Image>().fillAmount;
        }
        if (true)
        {
            Debug.Log("e");
            GetComponent<Image>().fillAmount = gauge - enemy5;
            gauge = GetComponent<Image>().fillAmount;
        }
    }
   */

}
  
