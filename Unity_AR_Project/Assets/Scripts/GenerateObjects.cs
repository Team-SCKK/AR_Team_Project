using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GenerateObjects : MonoBehaviour
{

   public GameObject item;

    public void SpawnObject() {
        Debug.Log("Spawning Item" + item.name);
        
        Vector3 pos = item.transform.position = new Vector3(0, 0, 1);
        Vector3 scale = item.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        PhotonNetwork.Instantiate(item.name, pos, Quaternion.identity, 0);
        //Instantiate(item);
    }
}
