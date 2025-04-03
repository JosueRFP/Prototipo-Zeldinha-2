using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    [SerializeField] Vector2 distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)distance * speed;
        Destroy(gameObject, 1.2f);
       
    }

    void ColOn()
    {
        Collider2D col = GetComponent<Collider2D>();

        if (col.gameObject.layer.Equals("Player"))
        {
            Destroy(col.gameObject);
        }
    }
    
}
