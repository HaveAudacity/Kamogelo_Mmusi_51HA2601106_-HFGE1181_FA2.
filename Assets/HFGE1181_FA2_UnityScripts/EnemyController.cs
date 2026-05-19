using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f;
    public int damage = 1;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
    }

    // SIDE HIT = DAMAGE PLAYER
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthSystem health = collision.gameObject.GetComponent<HealthSystem>();

            if (health != null)
            {
                health.Damage(damage);
            }
        }
    }

    // HEAD STOMP = DIE
    public void Die()
    {
        Destroy(gameObject);
    }
}