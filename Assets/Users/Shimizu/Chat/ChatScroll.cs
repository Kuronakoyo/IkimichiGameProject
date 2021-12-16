using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatScroll : MonoBehaviour
{
    private float scroll;
    public float speed = 10f;
    [SerializeField] private GameObject child1;
    [SerializeField]private GameObject child2;
  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        scroll = Input.GetAxis("Mouse ScrollWheel");
        Debug.Log(scroll);
        pos.y = transform.localPosition.y - scroll * speed;
        if(pos.y < -1350)
        {
            pos.y = -1350;
        }
        if (!child1.activeInHierarchy && pos.y > -1350)
        {
            pos.y = -1350;
        }
        if (child1.activeInHierarchy && pos.y > -1200)
        {
            pos.y = -1200;
        }
        if (child2.activeInHierarchy && pos.y > -800)
        {
            pos.y = -800;
        }
        transform.localPosition = pos;
        
    }
}
