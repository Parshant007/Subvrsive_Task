using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public float lifeTime = 1f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
        Destroy(gameObject, lifeTime);
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
