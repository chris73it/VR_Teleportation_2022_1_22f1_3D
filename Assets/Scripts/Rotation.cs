using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float targetRotationSpeed;

    public float currentRotSpeed;
    public float previousRotationSpeed;

    void Start()
    {
        currentRotSpeed = 0;
        previousRotationSpeed = Clockwise();
    }

    float Clockwise()
    {
        return targetRotationSpeed;
    }

    float CounterClockwise()
    {
        return -targetRotationSpeed;
    }

    public void StopRotation()
    {
        Debug.Log("StopRotation");

        if (currentRotSpeed != 0)
        {
            previousRotationSpeed = currentRotSpeed;
            currentRotSpeed = 0;
        }
    }

    public void Rotate()
    {
        Debug.Log("Rotate");

        if (currentRotSpeed == 0)
        {
            currentRotSpeed = previousRotationSpeed;
        }
        else if (currentRotSpeed == Clockwise())
        {
            currentRotSpeed = CounterClockwise();
        }
        else if (currentRotSpeed == CounterClockwise())
        {
            currentRotSpeed = Clockwise();
        }
    }

    void Update()
    {
        transform.Rotate(Vector3.up, currentRotSpeed * Time.deltaTime);
    }
}
