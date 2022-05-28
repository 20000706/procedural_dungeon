using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCopy : MonoBehaviour
{
    public GameObject dungeonOriginal;
    void Start()
    {
        GameObject DungeonClone =  Instantiate(dungeonOriginal);
    }
}
