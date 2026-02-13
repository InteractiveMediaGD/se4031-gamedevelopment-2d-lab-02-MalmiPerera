using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 20;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Try to find the PlayerHealth script on the object we hit
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            // Hurt the player using the method we made in Lab 01
            player.TakeDamage(damage);
            
            // Destroy the enemy so it doesn't hit us twice
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Clean up: If this object goes too far left, delete it
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}