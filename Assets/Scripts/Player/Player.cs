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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(Vector3.forward, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(-Vector3.forward, 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotate(-1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotate(1);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Move(Vector3.forward, 0);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Move(-Vector3.forward, 0);
        }
    }

    public void MoveControl()
    {

    }

    public void AttackControl()
    {

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
