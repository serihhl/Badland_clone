using UnityEngine;
using UnityEngine.InputSystem;

public class character : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 direction = Vector2.up;
    public float angularVelocity = 1f;
    public float angularDamping = 1f;
    public float spinTimer = 5f;
    Rigidbody2D rb;
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.angularDamping = 4f;
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

        spinTimer -= Time.deltaTime;
        if (spinTimer <= 0f)
        {
            stopSpinning();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.linearVelocity = direction.normalized * speed;
    }

    void stopSpinning()
    {
        if (angularVelocity > 0f)
        {
            rb.angularDamping = 4f;
        }
    }
}
