using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [Header("Jump Force Settings")]
    public float jumpForce = 500f;

    void OnCollisionEnter(Collision collision)
    {
        // Применяем силу вверх к объекту, который столкнулся с платформой
        collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
    }
}