using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Drag : MonoBehaviour
{
    // private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {

        // offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    void OnMouseDrag()
    {
        // Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        // transform.position = curPosition;
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }
}