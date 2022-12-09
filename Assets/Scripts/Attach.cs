using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{
    public bool isBallAttached = false;
    public bool isCubeCollider = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Attach::OnTriggerEnter other is " + other.gameObject.name);

        if (other.gameObject.name == "Ball")
        {
            Debug.Log("Attach::OnTriggerEnter Ball attached");
            isBallAttached = true;
        }
        else if (other.gameObject.name == "Cube_collider")
        {
            Debug.Log("Attach::OnTriggerEnter Cube_collider");
            isCubeCollider = true;
        }

        //if (other.gameObject.name == "Cube_collider")
        //{
        //    Debug.Log("Attach::OnTriggerEnter ball not attached");
        //    isBallAttached = false;
        //}
    }
}
