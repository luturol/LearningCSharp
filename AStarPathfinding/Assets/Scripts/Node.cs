using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    public bool Walkable { get; private set; }
    public Vector2 WorldPosition { get; private set; }

    public Node(bool walkable, Vector2 worldPosition)    
    {
        this.Walkable = walkable;
        this.WorldPosition = worldPosition;
    }

}
