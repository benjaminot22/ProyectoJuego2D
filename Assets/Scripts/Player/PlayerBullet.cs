using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private float lifeTime = 3f; 

    void Start()
    {
       
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Limite"))
        {
            Destroy(gameObject);
        }
    }
}