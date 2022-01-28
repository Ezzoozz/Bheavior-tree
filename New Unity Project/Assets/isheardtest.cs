using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class isheardtest : MonoBehaviour
{
    FirstPersonAIO player;

    float distance;

    float speed;

    Rigidbody rb;

    NavMeshAgent enemy;

    [SerializeField] float sprintDetection = 6f;

    [SerializeField] float walkdDetection = 3f;

    [SerializeField] float crouchDetection = 1.5f;
    void Awake()
    {
        player = GameObject.FindObjectOfType<FirstPersonAIO>();

        rb = GetComponent<Rigidbody>();

        enemy = GameObject.FindObjectOfType<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;

        distance = (transform.position - enemy.transform.position).magnitude;

        Debug.Log("speed: " + speed + " distance " + distance + " can hear "+ canHear() );

      

       

       

       // speeds= 6.4 ,3.2 ,1.6;
      
        

       

    }

     bool canHear()
    {
        if (speed > 6f && distance < sprintDetection)
        {
            return true;

        }

        else if (speed > 3f && distance < walkdDetection)
        {
            return true;

        }
        else if(speed > 1.4f && distance < crouchDetection)
        {
            return true;
        }

        return false;
    }
}
