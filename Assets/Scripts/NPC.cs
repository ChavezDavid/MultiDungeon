﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    public float moveSpeed;
    public float turnSpeed;

    Rigidbody rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    public void Move(Vector3 v3)
    {
        transform.Translate(v3 * moveSpeed * Time.deltaTime);
    }

    public void Rotate(int i)
    {
        transform.Rotate(Vector3.up * i * turnSpeed * Time.deltaTime);
    }
}