using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPosition4 : MonoBehaviour
{
    void Start()
    {
        Vector3 CtrlPos = transform.position;
        transform.position = new Vector3 (  GameObject.Find("OUTPUT_1_Instance4").transform.position.x - 80f, 
                                            GameObject.Find("OUTPUT_1_Instance4").transform.position.y + 1f, 
                                            GameObject.Find("OUTPUT_1_Instance4").transform.position.z  );
    }

    void Update ()
     {

    }
}