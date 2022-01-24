using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityGage : MonoBehaviour
{
    float sanityGage;       //SAN値
    float sanityMaxGage;    //SAN値の最大値
    float sanityDamage;     //ダメージ

    // Start is called before the first frame update
    void Start()
    {
        sanityMaxGage = 80;
        sanityGage = 80;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
