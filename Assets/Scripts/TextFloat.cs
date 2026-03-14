using UnityEngine;

public class TextFloat : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;

    [SerializeField]
    private float moveMagnitude = 50f;

    [SerializeField]
    private float rotationMagnitude = 2f;

    private Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        startPosition = transform.localPosition;
        startRotation = transform.localRotation;
    }

    void Update()
    {
        float x = (Mathf.PerlinNoise(Time.unscaledTime * speed, 0f) - 0.5f) * 2f * moveMagnitude;
        float y =
            (Mathf.PerlinNoise(0f, Time.unscaledTime * speed + 100f) - 0.5f) * 2f * moveMagnitude;
        float z =
            (Mathf.PerlinNoise(Time.unscaledTime * speed + 200f, 50f) - 0.5f)
            * 2f
            * rotationMagnitude;

        transform.localPosition = startPosition + new Vector3(x, y, 0f);
        transform.localRotation = startRotation * Quaternion.Euler(0f, 0f, z);
    }
}
