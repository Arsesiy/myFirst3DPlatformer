using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        // Запоминаем начальную позицию игрока
        startPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        // Возвращаем игрока в начальную позицию через new Vector3
        other.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
    }
}