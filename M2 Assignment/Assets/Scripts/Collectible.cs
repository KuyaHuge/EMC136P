using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int key;
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Key")
        {
            Debug.Log("Collected!");
            key = key + 1;
            Col.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
