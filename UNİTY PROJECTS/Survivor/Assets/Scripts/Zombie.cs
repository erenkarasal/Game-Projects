﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform  hedef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(hedef);
        GetComponent<Rigidbody>().AddForce(transform.forward * 6f, ForceMode.Acceleration);

    }
}
