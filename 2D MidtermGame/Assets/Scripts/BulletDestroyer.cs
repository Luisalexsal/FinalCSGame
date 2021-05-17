using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{

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
        if (collision.gameObject.tag == "Bullet1" || collision.gameObject.tag == "Bullet2")
        {
            Destroy(collision.gameObject);
            //Instantiate(explosion, transform.position, transform.rotation);
            //Destroy(gameObject);
        }
    }
    
}
