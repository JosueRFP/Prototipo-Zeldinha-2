using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StaffDef : MonoBehaviour
{
    [SerializeField] Transform invoker; 
    [SerializeField] GameObject invokeBarier;
    [SerializeField] float timerBarier;
    // Start is called before the first frame update
    void Start()
    {
        timerBarier--;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void InvokeBarier()
  {
       if (Input.GetButtonDown("Fire1"))
       {
           Instantiate(invokeBarier);
       }

      if (timerBarier == 0)
      {
         Destroy(invokeBarier);
      }
  }
}
