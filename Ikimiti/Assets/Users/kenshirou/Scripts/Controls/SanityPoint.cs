using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityPoint : MonoBehaviour
{
    [SerializeField]
    GameObject image;

    void Start()
    {
        image = GameObject.Find("Image");
    }

    void Update()
    {

    }

    public void HPDown(float current, int max)
    {
        image.GetComponent<Image>().fillAmount = current / max;
    }
}
