using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool Walkable { get; private set; }
    public Vector2 WorldPosition { get; private set; }
    public int GridX { get; private set; }
    public int GridY { get; private set; }
    public Node parent { get; set; }
    
    //Goal distance
    public int gCost { get; set; }

    //Heuristic Distance
    public int hCost { get; set; }
    
    public Node(bool walkable, Vector2 worldPosition, int gridX, int gridY)
    {
        this.Walkable = walkable;
        this.WorldPosition = worldPosition;
        this.GridX = gridX;
        this.GridY = gridY;
    }

    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }
}
