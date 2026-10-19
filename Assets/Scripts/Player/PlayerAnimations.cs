using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public float Velocidad = 5f;
    public float LongitudRaycast = 0.1f;
    public LayerMask CapaSuelo;
    private bool Ensuelo;
    public Animator animator;

    void Update()
    {
        float VelocidadX = Input.GetAxis("Horizontal") * Time.deltaTime * Velocidad;
        animator.SetFloat("Movement", VelocidadX * Velocidad);
        if (VelocidadX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (VelocidadX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, LongitudRaycast, CapaSuelo);
        Ensuelo = hit.collider != null;

        animator.SetBool("Ensuelo", Ensuelo);
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * LongitudRaycast);
    }

}

