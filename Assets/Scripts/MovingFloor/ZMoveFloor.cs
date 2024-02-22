using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMoveFloor : MoveFloor
{
    protected override void Update()
    {
        MoveZ();
    }
}
