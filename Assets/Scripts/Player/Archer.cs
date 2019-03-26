using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Player
{
    Animator anim;

    private GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        arrow = Resources.Load("Cube") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveControl(Vector3.forward, 1, anim);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveControl(-Vector3.forward, 1, anim);
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
            MoveControl(Vector3.forward, 0, anim);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            MoveControl(-Vector3.forward, 0, anim);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            AttackControl(anim, 1);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            AttackControl(anim, 0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ShootArrow();
        }
    }

    public void ShootArrow()
    {
        GameObject newArrow = Instantiate(arrow) as GameObject;
        newArrow.transform.position = transform.position;
        Rigidbody rbArrow = newArrow.GetComponent<Rigidbody>();
        rbArrow.velocity = transform.forward*15;
    }
}
