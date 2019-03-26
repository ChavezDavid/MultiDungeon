﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : NPC
{
    public int attackDamage = 15;
    public int damageBlock = 10;
    public GameObject target;
    public int lifePoints = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(Animator anim, int i)
    {
        anim.SetInteger("attack", i);
        BasicAttack();
        CriticAttack();
    }

    public void Block()
    {

    }

    public void ReceiveDamage()
    {

    }

    public void SetTarget(GameObject target)
    {

    }

}
