using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    public float rotationSpeed;
    void Update()
    {
        transform.Rotate(0f,0f,rotationSpeed * Time.deltaTime);
    }
}
