using UnityEngine;
using UnityEngine.InputSystem;

public class character : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 direction = Vector2.up;
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
         
    }
}
