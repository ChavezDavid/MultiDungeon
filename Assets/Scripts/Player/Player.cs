using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Follower
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveControl(Vector3 v3, int i, Animator anim)
    {
        Move(v3, i, anim);
    }

    public void AttackControl(Animator anim, int i)
    {
        Attack(anim, i);
    }

    public void BlockControll()
    {

    }

    public void ChangeLeader()
    {

    }

    public void GameControl()
    {

    }
}
