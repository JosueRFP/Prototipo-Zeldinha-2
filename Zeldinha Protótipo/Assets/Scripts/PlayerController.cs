using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public enum ChangeWeapon
{
    Sword, Staff
}
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerController : MonoBehaviour
{   
    Rigidbody2D rb;

    public GameObject sword, staff;
    [SerializeField] ChangeWeapon changeWeapon;
    [SerializeField] float vertical, speed, horizontal, life, maxLife, damege;
    [SerializeField] SpriteRenderer spriteRenderer;

    IEnemysDestroy enemysDestroy;
    public float Speed { get => speed; }
       
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        maxLife = life;
        rb = GetComponent<Rigidbody2D>();
        ChangeWeaponMode(ChangeWeapon.Sword);
    }

    // Update is called once per frame
    void Update()
    {
        damege -= maxLife;
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeWeaponMode(ChangeWeapon.Sword);
            Instantiate(sword);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeWeaponMode(ChangeWeapon.Staff);
            Instantiate(staff);
        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical) * Speed;
    }

    void ChangeWeaponMode(ChangeWeapon mode)
    {
        switch (mode)
        {
            case ChangeWeapon.Sword:
                GameController.instance.OnSwordMode.Invoke();
                break;
            case ChangeWeapon.Staff:
                GameController.instance.OnStaffMode.Invoke();
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {

        }
    }
}