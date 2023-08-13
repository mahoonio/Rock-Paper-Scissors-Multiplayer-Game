using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandControler : MonoBehaviour
{
    [SerializeField]
    private float speed = 7f;

   


    Animator hand_animator;
    void Start()
    {
        hand_animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (transform.position.x > 9.00f)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime, Space.World);
        }
        else
        {
            hand_animator.SetBool("startWalk", false);
        }

        

    }
}
