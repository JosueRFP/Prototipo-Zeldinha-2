using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StaffDef : MonoBehaviour
{
    [SerializeField] Transform invoker; 
    [SerializeField] GameObject barier;
    [SerializeField] float timerBarier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void InvokeBarier()
  {
       if (Input.GetButtonDown("Fire1"))
       {
           Instantiate(barier);
           TimerBarrier();
       }

      
  }
    void TimerBarrier()
    {
        if (timerBarier == 0)
        {
            Destroy(barier);
        }
    }
}
