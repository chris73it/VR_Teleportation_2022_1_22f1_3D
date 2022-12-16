using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneController : MonoBehaviour
{
    public float transDistance;
    public float downDistance;
    public float minDistance;
    public float maxDistance;
    public float minHeight = 6.5f;
    public float maxHeight  = 8f;
    public Transform ball;
    public Transform magnet;
    public Transform magnetOn;
    public Transform magnetOff;
    Attach attach;
    private void Awake()
    {
        attach = magnet.GetComponent<Attach>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        attach = magnet.GetComponent<Attach>();
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
        Vector3 tempPos = transform.position;

        if (transform.position.y > minHeight)
        {
            transform.Translate(Vector3.up * -downDistance * Time.deltaTime);
        }
        else
        {
            if (attach.isBallAttached)
            {
                transform.position = tempPos;
                if (attach.isCubeCollider)
                {
                    ball.parent = null;
                }
                else
                {

                    ball.parent = magnet.transform;
                    magnetOn.gameObject.SetActive(true);
                    magnetOff.gameObject.SetActive(false);
                }
            }
        }
    }

    public void craneUp()
    {
        transform.Translate(Vector3.up * downDistance * Time.deltaTime);
    }
}
