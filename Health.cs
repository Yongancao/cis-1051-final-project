using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHealth(float health)
    {
        this.health = health;
    }
    public void TakeDamage(float amount)
    {
        this.health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
