using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/MoveTowards")]
public class MoveTowardsFlock : FlockBehaviour
{
    public Vector3 Target;
    public float radius = 15f;

    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector3 targetOffset = Target - (Vector3)agent.transform.position;
        float t = targetOffset.magnitude / radius;
        if(t < 0.9f)
        {
            return Vector3.zero;
        }

        return targetOffset * t * t;
    }

}
