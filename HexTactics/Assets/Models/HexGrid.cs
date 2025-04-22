using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;


public class HexGrid : MonoBehaviour
{
    int[] cellHeights;
    int[] moveCost;
    int gridWidth, gridHeight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Takes cell, returns its neighbors in an array. If there is no cell in a direction, that spot will be null
    int?[] getNeighbors(int cell)
    {
        int?[] neighbors = new int?[0];
        if (cell % gridWidth == 0)
        {

        }
        return null;
    }

    // Takes start and end cells and finds the shortest path between them, ignoring terrain difficulty
    int[] pathFind(int startCell, int endCell)
    {
        return null;
    }

    // Takes start and end cells and finds the shortest path between them, including terrain difficulty
    int[] pathFindWithTerrain(int startCell, int endCell)
    {
        List<(int,int)> queue = new List<(int,int)>();
        queue.Add((startCell,0));
        while(queue.Count > 0)
        {

        }
        return null;
    }

    // Get all of the cells within a certain distance of a cell, ignoring terrain difficulty
    int[] getCellsInRange(int startCell, int range)
    {
        List<int> found = new List<int>();
        List<(int pos, int dist)> queue = new List<(int pos, int dist)>();
        queue.Add((startCell, 0));
        while(queue.Count > 0)
        {
            if (queue[0].dist > range)
            {
                return found.ToArray();
            }
            found.Add(queue[0].pos);
            int?[] next = getNeighbors(queue[0].pos);
            for(int i = 0; i < next.Length; i++)
            {
                if (next[i] is not null)
                {
                    if (!found.Contains((int)next[i]))
                    {
                        queue.Add(((int)next[i], queue[0].dist + 1));
                    }
                }
            }
            queue.Remove(queue[0]);
            queue.OrderBy(a => a.pos).ToList();
        }
        return new int[0];
    }
}
