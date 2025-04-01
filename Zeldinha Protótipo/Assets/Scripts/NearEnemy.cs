using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearEnemy : MonoBehaviour
{
    public Transform Player;
    public float velocity;
    public bool isRunning;
    public float distDetector;

    float distRun;
    private Vector2 directionToGo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distRun = Vector2.Distance(transform.position, Player.position);
        if(distRun <= distDetector && isRunning)
        {
            Run();
        }
        
    }

    void Run()
    {
        isRunning = true;
        directionToGo = (transform.position - Player.position).normalized;
    }
}
