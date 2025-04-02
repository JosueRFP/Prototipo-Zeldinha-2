using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class DestroyPlayer : MonoBehaviour
{
    [SerializeField] UnityEvent OnRestart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            Destroy(collision.gameObject);
            OnRestart.Invoke();
            print("Prescione R para reiniciar");
        }
    }
}
