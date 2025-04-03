using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObjects1 : MonoBehaviour, IDamegable
{
    
    public void DestroyGameObj()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
