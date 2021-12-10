using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fushinsya : MonoBehaviour
{
    SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        sp.color =sp.color - new Color32(0, 0, 0, 0);
        StartCoroutine("Transparent");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Transparent()
    {
        for (int i = 0; i < 255; i++)
        {
            sp.color = sp.color - new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(gameObject);
    }
}
