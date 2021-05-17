using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    public float jumpHeight;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public bool facingRight;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Fire();
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (rb != null)
        {
            ApplyInput();
        }
        else
        {
            Debug.LogWarning("RigidBody2d not attached to player");
        }
    }
    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal2");
        float yInput = Input.GetAxis("Vertical2");

        /*if (Input.GetButtonDown("Fire2"))
        {
            Fire();
        }*/

        float xForce = xInput * moveSpeed * Time.deltaTime;
        if ((xForce < 0 && facingRight) || xForce > 0 && !facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        float yForce = yInput * jumpHeight * Time.deltaTime;

        Vector2 forceX = new Vector2(xForce, 0);


        rb.AddForce(forceX);
        rb.AddForce(new Vector2(0, yForce), ForceMode2D.Impulse);
    }
    void Fire()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 10;
        Destroy(bullet, 4.5f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            Destroy(collision.gameObject);
            //Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this);
            Destroy(gameObject);
        }
    }

}