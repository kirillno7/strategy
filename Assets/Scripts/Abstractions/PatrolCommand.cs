using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolCommand : IPatrolCommand
{

    private Vector3 SelectableValuepos;

    private Vector3 GroundClick;





    public PatrolCommand(Vector3 selectableValuepos, Vector3 groundClick)
    {
        SelectableValuepos = selectableValuepos;
        GroundClick = groundClick;
    }

    public Vector3 From => SelectableValuepos;

    public Vector3 To => GroundClick;
}

