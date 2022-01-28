using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

using static BehaviorDesigner.Runtime.BehaviorManager;

public class Direction : MonoBehaviour
{
    // Start is called before the first frame update

    FirstPersonAIO player;


    void Start()
    {
        player = GameObject.FindObjectOfType<FirstPersonAIO>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceVector = (player.transform.position - transform.position);

        float angle = Vector3.Angle(transform.forward, distanceVector);

        Debug.Log(angle);
    }
}
