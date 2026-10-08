using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 6f;

    [SerializeField] private float fireRate = 5f; // Cada cuántos segundos dispara
    private float nextFireTime = 0f;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Configuramos la bala como enemiga
        EnemyBullet proj = bullet.GetComponent<EnemyBullet>();
        if (proj != null)
        {
            proj.tipoProyectil = "Enemy";
        }

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(-bulletSpeed, 0f); // Dispara hacia la izquierda (ajusta según necesidad)
    }
}
