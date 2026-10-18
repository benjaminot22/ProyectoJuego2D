using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    private bool enMovimiento;
    private Animator animator;
    public float velocidad = 2f;

    private int direccion = -1;

    void Start()
    {
        animator = GetComponent<Animator>();
        enMovimiento = true;
        animator.SetBool("enMovimiento", enMovimiento);
    }

    void Update()
    {
        
        transform.Translate(new Vector2(direccion * velocidad * Time.deltaTime, 0));
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player") == false)
        {
            
            direccion = direccion * -1;
            if (direccion > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (direccion < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        else
        {
            collision.gameObject.GetComponent<PlayerStats>().TakeDamage(10);
        }

       
       
        
    }
}


