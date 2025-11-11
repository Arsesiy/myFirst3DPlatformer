using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private Vector3 startPosition;
    public LifesManager lm;
    void Start()
    {
        // Запоминаем начальную позицию игрока
        startPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerController>(out var player))
        {
            LifesManager lifesManager = FindAnyObjectByType<LifesManager>();
            if (lifesManager != null && lifesManager.IsAlive)
            {
                // Возвращаем игрока в начальную позицию через new Vector3
                other.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
                lifesManager.loseLifes();
            }
            else
            {   
                Debug.Log("Game Over");
                SceneManager.LoadScene("MainMenuScene");
            }
        }
        
    }
}