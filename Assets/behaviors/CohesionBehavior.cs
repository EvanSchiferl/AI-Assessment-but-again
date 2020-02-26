using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Cohesion")]

public class CohesionBehavior : Flockbehav
{
    public override Vector3 CalculatedMove(flockagent agent, List<Transform> context, flock flock)
    {
        //if no neighbors, return no adjustment
        if (context.Count == 0)
            return Vector3.zero;

        //add points and average
        Vector3 cohesionMove = Vector3.zero;
        foreach (Transform item in context)
        {
            cohesionMove += item.position;
        }
        cohesionMove /= context.Count;

        //offset
        cohesionMove -= agent.transform.position;

        return cohesionMove;
    }
}
