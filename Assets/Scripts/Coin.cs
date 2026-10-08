using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoMoneda;

    [SerializeField] private int coins = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sfxSource.PlayOneShot(sonidoMoneda);
            print("¡Moneda recolectada!");
          
            PlayerStats playerCoins = collision.GetComponent<PlayerStats>();
            {
                playerCoins.TakeCoins(coins);
            }
            Destroy(gameObject);
        }
    }

}
