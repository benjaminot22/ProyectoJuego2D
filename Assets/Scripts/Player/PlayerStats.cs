using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoDamage;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int startCoins = 0;
    private int currentHealth;
    public int currentcoins;

    void Start()
    {
        currentHealth = maxHealth;
        currentcoins = startCoins;
    }

    public void TakeDamage(int damage)
    {
        sfxSource.PlayOneShot(sonidoDamage);
        currentHealth -= damage;
        Debug.Log("¡Jugador atacado! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("¡El jugador ha muerto!");
            // gameObject.SetActive(false);
        }
    }

    public void TakeCoins(int coins)
    {
        currentcoins += coins;
        Debug.Log("Monedas conseguidas: " + currentcoins);

    }
}