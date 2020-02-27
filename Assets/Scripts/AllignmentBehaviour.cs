using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behvaiour/Allignment")]
public class AllignmentBehaviour : FlockBehaviour
{
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        // if no neighbours, maintain current allignment
        if (context.Count == 0)
        {
            return agent.transform.up;
        }

        //add all points together and average
        Vector3 allignmentMove = Vector3.zero;
        foreach (Transform item in context)
        {
            allignmentMove += item.transform.up;
        }
        allignmentMove /= context.Count;

        return allignmentMove;
    }

   
}
