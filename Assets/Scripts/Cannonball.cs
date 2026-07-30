using UnityEngine;

public class Cannonball : MonoBehaviour
{
    [SerializeField] float _damage;
    [SerializeField] float _lifetime = 5;

    void Start()
    {
        Destroy(gameObject, _lifetime);
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        //when the ball collides with something, deal damage to it!
        Debug.Log($"Collided with object: {collision.gameObject.name}");

        if (collision.gameObject.CompareTag("Enemy")) 
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(_damage);
        }
    }
}
