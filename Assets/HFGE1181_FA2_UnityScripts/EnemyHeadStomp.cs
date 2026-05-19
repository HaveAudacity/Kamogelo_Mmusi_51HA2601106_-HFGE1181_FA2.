using UnityEngine;

public class EnemyHeadStomp : MonoBehaviour
{
    private EnemyController enemy;

    void Start()
    {
        enemy = GetComponentInParent<EnemyController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemy.Die();
        }
    }
}