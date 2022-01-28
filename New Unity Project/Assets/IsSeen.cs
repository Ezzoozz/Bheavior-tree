using BehaviorDesigner.Runtime.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSeen : Conditional
{
    FirstPersonAIO player;

    [SerializeField] float fieldOfViewAngle = 30f;

    [SerializeField] float seeDistance = 10f;

   

    public override void OnAwake()
    {
        

        player = GameObject.FindObjectOfType<FirstPersonAIO>();
    }
    public override TaskStatus OnUpdate()
    {

        // Debug.Log(withinSight(player));
        if (withinSight(player))
        {
            
            return TaskStatus.Success;
            
        }


        return TaskStatus.Failure;


    }

    private bool withinSight(FirstPersonAIO player)
    {
        Vector3 distanceVector =  (player.transform.position - transform.position);

        float distance = distanceVector.magnitude;

     

       
        float betweenAngle = Vector3.Angle(transform.forward, distanceVector);

      //  Debug.Log("angle between " + betweenAngle + " distance " + distance);

        if (betweenAngle>fieldOfViewAngle) return false;

        if (distance > seeDistance)
            return false;



        return true;
   
       

    }
}
