﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuScript : MonoBehaviour
{
    [MenuItem("Tools/Assign Tile Material")]
    public static void AssignTileMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("Tile");
        foreach(GameObject t in tiles)
        {
            t.GetComponent<Renderer>().material = material;
        }
    }
}
