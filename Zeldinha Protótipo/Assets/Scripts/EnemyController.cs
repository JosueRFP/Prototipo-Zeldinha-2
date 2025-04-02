using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject[] enemys;
    public GameObject[] spawn;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawn.Length; i++)
        {
            spawn[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
