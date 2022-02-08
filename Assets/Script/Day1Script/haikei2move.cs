using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haikei2move : MonoBehaviour
{
    [SerializeField]
    GameObject _movebtn;
    [SerializeField]
    GameObject _san;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            _movebtn.SetActive(true);
            _san.SetActive(true);
        }
    }
}
