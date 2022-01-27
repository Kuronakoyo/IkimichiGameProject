using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.activeInHierarchy == true)
        {
            StartCoroutine("Fade");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameOver");
    }

  }
