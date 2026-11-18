using System.Reflection.Metadata.Ecma335;
using UnityEngine;
using UnityEngine.InputSystem;

public class character : MonoBehaviour
{
    public float freeSpinTime = 2f;
    public float speed = 5f;
    public Vector2 direction = Vector2.up;
    public float angularVelocity = 1f;
    public float angularDampingFactor = 1f;
    float spinTimer = 0f;
    public float autoSteerFactor;
    Rigidbody2D rb;
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void flyingForward()
    {
        rb.linearVelocity = direction * speed;
    }
    
    void FixedUpdate()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            flyingForward();
        }
        spinTimer += Time.deltaTime;
        rb.angularDamping = spinTimer * angularDampingFactor;
        float t = Mathf.Min(spinTimer - freeSpinTime);
        var rot = Quaternion.RotateTowards(transform.rotation, Quaternion.identity, t * autoSteerFactor * Time.deltaTime);
        rb.SetRotation(rot);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spinTimer = 0;
    }

    void stopSpinning()
    { 
        if (angularVelocity > 0f)
        {
            rb.angularDamping = 4f;
            transform.rotation = Quaternion.identity;
        }
    }

    public void PickUpActivated(PickUpItemType pickup) {

        if (pickup == PickUpItemType.BiggerChar) {
            transform.localScale = new Vector2(2, 2);
        }
        else if (pickup == PickUpItemType.SmallerChar) {
            transform.localScale = new Vector2(0.5f, 0.5f);
        }

    }
}
