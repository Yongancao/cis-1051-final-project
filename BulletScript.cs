using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletDamage;
    public PlayerStats stats;
    public void Awake()
    {
        bulletDamage = stats.damage;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            if (collision.gameObject.GetComponent<Health>() != null)
            {   
                collision.gameObject.GetComponent<Health>().TakeDamage(bulletDamage);
             
            }

        }
        Destroy(gameObject);
    }
}
