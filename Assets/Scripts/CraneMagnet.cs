using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMagnet : MonoBehaviour
{
    public float transDistance;
    public float downDistance;
    public float minDistance;
    public float maxDistance;
    public float minHeight;
    public float maxHeight;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onCollision()
    {

    }
    public void craneLeft()
    {
        transform.Translate(Vector3.right * -transDistance * Time.deltaTime);
    }
    public void craneRight()
    {
        transform.Translate(Vector3.right * transDistance * Time.deltaTime);
    }
    public void craneDown()
    {
        transform.Translate(Vector3.up * -downDistance * Time.deltaTime);
    }
}
