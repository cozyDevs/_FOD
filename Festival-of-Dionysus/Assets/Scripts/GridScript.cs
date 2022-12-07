using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class GridScript : MonoBehaviour
{
    void Start()
    {
        AstarPath.active.Scan();
    }
}
