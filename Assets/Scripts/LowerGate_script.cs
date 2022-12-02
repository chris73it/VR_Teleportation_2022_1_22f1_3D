using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerGate_script : MonoBehaviour
{
    public float downDistance;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void lowerGate()
    {
        transform.Translate(Vector3.up * -downDistance * Time.deltaTime);
    }
}
