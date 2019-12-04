using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DragSnowball : MonoBehaviour
{
    private Vector3 mOffset;
    private Rigidbody rb;
    private float mZCoord;

    private bool isMouseMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") < -0.1 || Input.GetAxis("Mouse X") > 0.1 || Input.GetAxis("Mouse Y") > 0.1 || Input
                .GetAxis("Mouse Y") < -0.1)
        {
            //Code for action on mouse moving left
            print("Mouse moving");
            isMouseMoving = true;
        }
        else
        {
            isMouseMoving = false;
        }
        
        if(rb.velocity.magnitude > 0.01 && isMouseMoving)
        {
            //Debug.Log("rolling snowball");
            gameObject.transform.localScale+= new Vector3(0.01f, 0.01f, 0.01f);
        }
    }

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mPoint = Input.mousePosition;
        mPoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mPoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
