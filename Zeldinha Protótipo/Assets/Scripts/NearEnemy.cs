using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearEnemy : MonoBehaviour, IEnemysDestroy
{
    [SerializeField] int damege;
    [SerializeField] float health;
    public void TakeDamege(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
