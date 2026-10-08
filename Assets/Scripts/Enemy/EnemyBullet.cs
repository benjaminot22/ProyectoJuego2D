using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int damage = 20;
    [SerializeField] private float lifeTime = 5f;
    public string tipoProyectil = "Enemy"; // "Player" o "Enemy"

    void Start()
    {
        Destroy(gameObject, lifeTime); // Red de seguridad
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tipoProyectil == "Enemy" && collision.CompareTag("Player"))
        {
            PlayerStats playerHealth = collision.GetComponent<PlayerStats>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Suelo"))
        {
            Destroy(gameObject);
        }
    }
}