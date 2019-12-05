using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    public GameObject item;
    private float x = 0;
    private float y = 0;
    private float z = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void DragItem() {
        item.transform.position += new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
