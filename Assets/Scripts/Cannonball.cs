using UnityEngine;

public class Cannonball : MonoBehaviour
{
    float damage;

    void OnCollisionEnter2D (Collision collision)
    {
        //when the ball collides with something, deal damage to it!
        Debug.Log($"Collided with object: {collision.gameObject.name}");
    }
}
