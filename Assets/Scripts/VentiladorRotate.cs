using UnityEngine;

public class VentiladorRotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float maxRotationSpeed = 310;
    public float minRotationSpeed = 300;

    float rotationSpeed = 0;
    void Start()
    {
        rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
