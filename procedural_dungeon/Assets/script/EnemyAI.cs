using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Rigidbody rb;
    public string heading;
    private List<string> direcs = new List<string>{ "F", "B", "L", "R"};
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        heading = direcs[Random.Range(0, 3)];
        if (rb.velocity.magnitude <= 0.01f)
        {
            StartCoroutine("Wait");
        }
    }

    void OnCollisionEnter(Collision collision)
        {
            heading = direcs[Random.Range(0, 3)];
        }

    void Update()
    {   
        if (heading == "F") 
        {
            rb.velocity = new Vector3(0, 0, 1) * moveSpeed;
        }
        if (heading == "B") 
        {
            rb.velocity = new Vector3(0, 0, -1) * moveSpeed;
        }
        if (heading == "L") 
        {
            rb.velocity = new Vector3(-1, 0, 0) * moveSpeed;
        }
        if (heading == "R")
        {
            rb.velocity = new Vector3(1, 0, 0) * moveSpeed;
        }
    }

    IEnumerator Wait()
    {  
        while (true)
        {
            yield return new WaitForSeconds(3);
            ChangeDirec();
        }
    }

    void ChangeDirec()
    {
        if (heading == direcs[0])
        {
            List<string> exceptF = new List<string>(direcs);
            exceptF.Remove("F");
            heading = exceptF[Random.Range(0, 2)];
        }
        if (heading == direcs[1])
        {
            List<string> exceptB = new List<string>(direcs);
            exceptB.Remove("B");
            heading = exceptB[Random.Range(0, 2)];
        }
        if (heading == direcs[2])
        {
            List<string> exceptL = new List<string>(direcs);
            exceptL.Remove("L");
            heading = exceptL[Random.Range(0, 2)];
        }
        if (heading == direcs[3])
        {
            List<string> exceptR = new List<string>(direcs);
            exceptR.Remove("R");
            heading = exceptR[Random.Range(0, 2)];
        }
    }
}
