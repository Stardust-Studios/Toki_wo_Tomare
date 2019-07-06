using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition);
        if (
            Input.GetMouseButtonDown(0)
            //Input.mousePosition.y > this.GetComponent<BoxCollider2D>().bounds.min.y && Input.mousePosition.y < this.GetComponent<BoxCollider2D>().bounds.max.y &&
            //Input.mousePosition.x > this.GetComponent<BoxCollider2D>().bounds.min.x && Input.mousePosition.x < this.GetComponent<BoxCollider2D>().bounds.max.x
            )
        {
            this.GetComponent<Transform>().localScale = new Vector3(2, 2, 0);
            this.GetComponent<Transform>().position = Input.mousePosition;
        }
        else
        {
            this.GetComponent<Transform>().localScale = new Vector3(1, 1, 0);
        }
    }
}
