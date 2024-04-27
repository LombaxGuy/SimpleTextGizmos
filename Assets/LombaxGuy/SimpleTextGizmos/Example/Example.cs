using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LombaxGuy.SimpleTextGizmos;

public class Example : MonoBehaviour
{
    private Vector3[][] grid;

    private void OnValidate()
    {
        if (grid == null)
        {
            grid = new Vector3[10][];

            for (int y = 0; y < 10; y++)
            {
                grid[y] = new Vector3[10];

                for (int x = 0; x < 10; x++)
                {
                    grid[y][x] = new Vector3(x, y);
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;

        for (int y = 0; y < grid.Length; y++)
        {
            for (int x = 0; x < grid[y].Length; x++)
            {
                TextGizmo.Draw($"({x}, {y})", new Vector3(x + .5f, 0, y + .5f), new Vector3(90, 0), 0.2f);
            }
        }

        Gizmos.color = Color.white;

        TextGizmo.Draw("Simple Text Gizmos", new Vector3(1.5f, 4.0f, 1.5f), new Vector3(30, 45, 0), 0.8f);
    }
}
