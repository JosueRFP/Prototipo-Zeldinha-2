using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongAimEnemyController : MonoBehaviour
{
    [SerializeField] Transform arrowPoint;
    [SerializeField] GameObject arrowPrefab;
    [SerializeField] float fireTimeRate, arrowSpeed;
    
    private float nextArrow;

    public float life;
    public float damege;
    // Start is called before the first frame update
    void Start()
    {
        life = 5f;
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
}
