using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandomLocation : Action
{
    public Transform [] transforms;

    public SharedVector3 goal = null;
    // Start is called before the first frame update
    void Start()
    {
        GameObject [] goals = GameObject.FindGameObjectsWithTag("goal");

        transforms = new Transform[goals.Length];

        for(int i = 0; i < goals.Length; i++)
        {
            transforms[i] = goals[i].transform;
        }
    }

     public override TaskStatus OnUpdate()
    {
        int random = Random.Range(0, transforms.Length - 1);

        if (transforms[random] == null)
            return TaskStatus.Failure;


        goal.Value = transforms[random].position;
        

        return TaskStatus.Success;



    }
}
