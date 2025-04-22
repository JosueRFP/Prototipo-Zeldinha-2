using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectAtack : MonoBehaviour
{
    public int damege;
    public void TakeDamege(int amount)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        IEnemysDestroy enemysDestroy = col.GetComponent<IEnemysDestroy>();
        if (enemysDestroy != null)
        {
            enemysDestroy.TakeDamege(damege);
            Destroy(col.gameObject);
        }

        if (col.gameObject.layer.Equals("Personas"))
        {
            Destroy(col.gameObject);
        }
    }

}
