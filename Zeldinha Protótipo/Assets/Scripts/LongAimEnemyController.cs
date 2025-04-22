using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongAimEnemyController : MonoBehaviour, IEnemysDestroy
{
    public float health = 5f;
    [SerializeField] Transform arrowPoint;
    [SerializeField] GameObject arrowPrefab, swordCollider;
    [SerializeField] float fireTimeRate, arrowSpeed;
    
    private float nextArrow;

    public float life;
    public float damege;


    public void TakeDamege(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    } 

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextArrow)
        {
            Fire();
            nextArrow = Time.time + fireTimeRate;
        }
    }

    void Fire()
    {
        Instantiate(arrowPrefab, arrowPoint.position, arrowPoint.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer.Equals("Personas"))
            life--;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

}
