using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObjects1 : MonoBehaviour, IDamegable
{
    IDamegable damegable;

    public void DestroyGameObj()
    {
        Collider2D col = GetComponent<Collider2D>();
        if(col.gameObject)
        {
            Destroy(col.gameObject) ;
        }
    }


}
