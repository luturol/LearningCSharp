using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPath : MonoBehaviour
{    
    [Header("Configurations")]
    public LayerMask unwalkableMask;
    public Vector2 gridWorldSize;
    public float nodeRadius;

    private Node[,] grid;
    private float nodeDiameter;
    private int gridSizeX;
    private int gridSizeY;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        nodeDiameter = nodeRadius * 2;
        gridSizeX = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridWorldSize.y / nodeDiameter);
        CreateGrid();
    }

    private void CreateGrid()
    {
        grid = new Node[gridSizeX, gridSizeY];
        Vector2 worldBottomLeft = new Vector2(transform.position.x, transform.position.y) - Vector2.right * gridSizeX / 2 - Vector2.up * gridSizeY / 2;

        //check for collisions and create grid
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Vector2 worldPoint = worldBottomLeft + Vector2.right * (x * nodeDiameter + nodeRadius) + Vector2.up * (y * nodeDiameter + nodeRadius);
                bool walkable = !(Physics2D.OverlapCircle(worldPoint, nodeRadius, unwalkableMask));                
                grid[x, y] = new Node(walkable, worldPoint);
                Debug.Log( grid[x, y].Walkable);
            }
        }
    }

    public Node NodeFromWorldPoint(Vector2 worldPosition)
    {
        float percentX = (worldPosition.x + gridWorldSize.x / 2) / gridWorldSize.x;
        float percentY = (worldPosition.y + gridWorldSize.y / 2) / gridWorldSize.y;

        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);
        
        int x = Mathf.RoundToInt(percentX * (gridSizeX - 1));
        int y = Mathf.RoundToInt(percentY * (gridSizeY - 1));

        return grid[x, y];
    }

    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, gridWorldSize.y, 0));
        
        if(grid != null)
        {
            foreach(Node node in grid)
            {
                Gizmos.color = (node.Walkable) ? Color.white : Color.red;

                Gizmos.DrawCube(node.WorldPosition, Vector2.one * (nodeDiameter - .1f ));
            }
        }
    }
}
