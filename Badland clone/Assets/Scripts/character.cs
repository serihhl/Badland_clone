using System.Reflection.Metadata.Ecma335;
using UnityEngine;
using UnityEngine.InputSystem;

public class character : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 direction = Vector2.up;
    public Vector3 spinning = Vector3.zero;
    public float angularVelocity = 1f;
    public float angularDamping = 1f;
    public float spinTimer = 5f;
    Rigidbody2D rb;
    
    
    
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
        spinTimer -= Time.deltaTime;
        if (spinTimer <= 0f)
        {
            stopSpinning();
            rb.angularDamping = 1f;
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
            transform.rotation = Quaternion.identity;
        }
    }
}
