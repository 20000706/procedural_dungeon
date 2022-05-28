using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPosition1 : MonoBehaviour
{
    void Start()
    {
        Vector3 CtrlPos = transform.position;
        transform.position = new Vector3 (  GameObject.Find("OUTPUT_1_Instance1").transform.position.x -80, 
                                            GameObject.Find("OUTPUT_1_Instance1").transform.position.y, 
                                            GameObject.Find("OUTPUT_1_Instance1").transform.position.z  );
    }

    void Update ()
     {

    }
}