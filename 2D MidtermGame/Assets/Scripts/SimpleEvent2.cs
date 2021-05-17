using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEvent2 : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent event1;
    public GameObject obj1;
    //public GameObject obj2;
    
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
            //event1.Invoke();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            event1.Invoke();
            Application.LoadLevel(3);
        }
    }
}

