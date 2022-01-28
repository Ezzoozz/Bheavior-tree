using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomComparePositions : Conditional
{
  [SerializeField] public SharedVector3 position1;
  [SerializeField] public SharedVector3 position2;
   
    // Start is called before the first frame update
    public override void OnAwake()
    {
        

    } 

    // Update is called once per frame
    public override TaskStatus OnUpdate()
    {
        Vector2 playerPos = new Vector2(position1.Value.x,position1.Value.z);

        Vector2 enemyPos = new Vector2(position2.Value.x, position2.Value.z);

        Debug.Log("difference in position");

        if((playerPos - enemyPos).magnitude<=0.3)
        {

            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Failure;
        }


    }

}
