using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;
    public Transform PointC;
    void Start()
    {
        transform.LookAt(PointA);
    }
    private void Update()
    {
       transform.Translate(Vector3.forward * 3 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PointA")
        {
            transform.LookAt(PointB);
        }
        else if (other.gameObject.name == "PointB")
        {
            transform.LookAt(PointC);
        }
        else if (other.gameObject.name == "PointC")
        {
            transform.LookAt(PointA);
        }
    }
}

