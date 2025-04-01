using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChangeWeapon
{
    Sword, Staff
}

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb;
    [SerializeField] float vertical, horizontal, life, maxLife, damege;
    [SerializeField] float speed;
    [SerializeField] bool facingRight;
    [SerializeField] SpriteRenderer spriteRenderer;

    public float Speed { get => speed; }
       
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        maxLife = life;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        damege -= maxLife;
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical) * Speed;
    }
}