using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoDamage;
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        sfxSource.PlayOneShot(sonidoDamage);
        currentHealth -= damage;
        Debug.Log("¡Jugador atacado! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("¡El jugador ha muerto!");
            
        }
    }

}