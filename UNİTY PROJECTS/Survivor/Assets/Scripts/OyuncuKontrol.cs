﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public Transform mermipos;
    public GameObject mermi; 
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject go = Instantiate(mermi,mermipos.position,mermipos.rotation) as GameObject ;
            go.GetComponent<Rigidbody>().velocity=mermipos.transform.forward*10f;
            Destroy(go.gameObject,2f);

        }
            
        
    }
}
