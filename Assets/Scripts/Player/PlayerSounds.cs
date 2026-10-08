using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoPrueba;

    void Start()
    {
        
    }

   
    void Update()
    {
        // Si el jugador presiona la tecla 'O' en su teclado
        if (Input.GetKeyDown(KeyCode.O))
        {
            // Reproduce el clip de audio una sola vez
            sfxSource.PlayOneShot(sonidoPrueba);
        }

    }
}
