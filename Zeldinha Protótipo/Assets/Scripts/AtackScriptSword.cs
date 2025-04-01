using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackScriptSword : MonoBehaviour
{
   [SerializeField] Transform effectController;
   [SerializeField] GameObject atackEfect1;
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EfectControllerTimer()); 
    }

    // Update is called once per frame
    void Update()
    {
        CollisionOnEnemys();
    }

    
    void InstatiateEffect()
    {
        GameObject atackEfect = Instantiate(atackEfect1, effectController.position, effectController.rotation);
        Destroy(atackEfect, 0.2f);
    }

    void CollisionOnEnemys()
    {
        Collider2D col = GetComponent<Collider2D>();
        if (Input.GetButtonDown("Fire1"))
        {            
            if (col.gameObject)
            {
                InstatiateEffect();
                EfectControllerTimer();
                
            }
        }
        
    }

    IEnumerator EfectControllerTimer()
    {
        yield return new WaitForSeconds(3);
    }
}
