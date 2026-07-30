using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private float maxHealth;

    private float currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    public float GetHealth() 
    {
        return currentHealth;
    }

    public void TakeDamage(float damage) 
    {
        Debug.Log("Enemy takes damage");
        
        currentHealth -= damage;

        if (currentHealth <= 0) 
        {
            Defeated();
        }
    }

    void Defeated() 
    {
        Debug.Log("DEFEATED");

        GameManager.GetInstance().IncrementScore();
        Destroy(gameObject);
    }
}
