using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class isHeard : Conditional
{
    FirstPersonAIO player;

    float distance;

    float speed;

    Rigidbody rb;

  

    [SerializeField] float sprintDetection = 6f;

    [SerializeField] float walkdDetection = 3f;

    [SerializeField] float crouchDetection = 1.5f;
    public override void OnAwake()
    {
        player = GameObject.FindObjectOfType<FirstPersonAIO>();

        rb = player.GetComponent<Rigidbody>();

        
    }


    // Update is called once per frame
    public override TaskStatus OnUpdate()
    {
        speed = rb.velocity.magnitude;

        distance = (player.transform.position - transform.position).magnitude;

        Debug.Log("speed: " + speed + " distance " + distance + " can hear " + canHear());


        if (canHear())
            return TaskStatus.Success;

        return TaskStatus.Failure;




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
        else if (speed > 1.4f && distance < crouchDetection)
        {
            return true;
        }

        return false;
    }
}
