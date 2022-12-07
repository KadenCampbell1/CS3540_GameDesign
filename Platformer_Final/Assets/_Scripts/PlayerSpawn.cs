using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public VectorData spawnLoc;
    private void Start()
    {
        transform.position = spawnLoc.value;
    }
}
