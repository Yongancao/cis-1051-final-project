using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float damage;
    public float health;
    public float attackSpeed;

    public Rigidbody2D rb;
    public Camera cam;
    Vector2 movement;
    Vector2 mousePos;
    public HealthBar healthBar;


    public PlayerStats stats;

    public void Start()
    {

        SetPlayerValue();
        healthBar.SetMaxHealth(health);
    }


    public void SetPlayerValue()
    {
        health = stats.health;
        damage = stats.damage;
        speed = stats.speed;
        attackSpeed = stats.attackSpeed;
    }
    
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        Vector2 lookdir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }

}
