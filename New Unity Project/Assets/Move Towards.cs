using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTowards : Action
{
    NavMeshAgent enemy;
    
    public override void OnStart()
    {
        base.OnStart();

        enemy = GetComponent<NavMeshAgent>();


       

        

        
        
    }


}
