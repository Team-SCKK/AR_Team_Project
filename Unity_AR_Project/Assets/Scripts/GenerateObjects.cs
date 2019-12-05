using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour
{

   public GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SpawnObject() {
        Debug.Log("Spawning Item");
        
        item.transform.position = new Vector3(0, 0, 1);
        item.transform.localScale = new Vector3((float)(0.05), (float)0.05, (float)0.05);
        Instantiate(item);
    }
}
