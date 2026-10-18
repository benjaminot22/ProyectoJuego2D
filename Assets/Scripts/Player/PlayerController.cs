using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoSalto;
    public float Velocidad = 5f;
    public float FuerzaSalto = 10f;
    private bool Ensuelo;
    public float LongitudRaycast = 0.1f;
    public LayerMask CapaSuelo;
    private Rigidbody2D rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float VelocidadX = Input.GetAxis("Horizontal") * Time.deltaTime * Velocidad;
        Vector3 posicion = transform.position;
        transform.position = new Vector3(VelocidadX + posicion.x, posicion.y, posicion.z);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, LongitudRaycast, CapaSuelo);
        Ensuelo = hit.collider != null;

        if (Ensuelo && Input.GetKeyDown(KeyCode.Space))
        {
            sfxSource.PlayOneShot(sonidoSalto);
            rb.AddForce(new Vector2(0f, FuerzaSalto), ForceMode2D.Impulse);
        }


    }

}
