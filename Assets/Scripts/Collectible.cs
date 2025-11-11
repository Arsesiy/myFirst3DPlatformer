using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject particle;
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            CoinsManager coinCounter = FindObjectOfType<CoinsManager>();
            if (coinCounter != null)
            {
                coinCounter.CollectCoin();
            }
            // Уничтожаем текущий объект
            Destroy(gameObject);
            Instantiate(particle).transform.position = transform.position;
        }
    }
}
