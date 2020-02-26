using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class flockbehav : ScriptableObject
{
    public abstract Vector3 calculateMove(flockagent agent, List<Transform> context, flock flock);
}
