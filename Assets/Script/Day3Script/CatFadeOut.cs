using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFadeOut : MonoBehaviour
{
    Animator _anim;

    void Start()
    {
        _anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf == true)
        {
            _anim.SetBool("Flag", true);
            //Debug.Log("koko");
        }
    }
}
