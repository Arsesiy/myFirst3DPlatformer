using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2f;
    public float distance = 5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Используем PingPong для автоматического движения туда-обратно
        float x = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + Vector3.right * x;
    }
}