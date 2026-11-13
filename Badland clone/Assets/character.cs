using UnityEngine;
using UnityEngine.InputSystem;

public class character : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 direction = Vector2.up;
    public float angularVelocity = 1f;
    public float angularDamping = 1f;
    Rigidbody2D rb;
    CircleCollider2D cc;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void flyingForward()
    {
        rb.linearVelocity = direction * speed;
    }
    
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            flyingForward();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.linearVelocity = direction.normalized * speed;
    }


}
