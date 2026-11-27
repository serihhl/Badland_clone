using System.Reflection.Metadata.Ecma335;
using UnityEngine;
using UnityEngine.InputSystem;

public class character : MonoBehaviour, IDamageable
{
    public float freeSpinTime = 2f;
    public float speed = 5f;
    public Vector2 direction = Vector2.up;
    public float angularVelocity = 1f;
    public float angularDampingFactor = 1f;
    float spinTimer = 0f;
    public float autoSteerFactor;
    Rigidbody2D rb;
    Vector2 scale;
    GameManager gm;
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = FindAnyObjectByType<GameManager>();
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
    public void PickUpActivated(PickUpItemType pickup) {

        if (pickup == PickUpItemType.BiggerChar) {
            transform.localScale = new Vector2(transform.localScale.x * 1.25f, transform.localScale.y * 1.25f);
            Physics2D.gravity = new Vector2(Physics2D.gravity.x * 1.25f, Physics2D.gravity.y * 1.25f);
        }
        else if (pickup == PickUpItemType.SmallerChar) {
            transform.localScale = new Vector2(transform.localScale.x * 0.75f, transform.localScale.y * 0.75f);
            Physics2D.gravity = new Vector2(Physics2D.gravity.x * 0.85f, Physics2D.gravity.y * 0.85f);
        }

    }
    public void TakeDamage(float damage)
    {
        Destroy(gameObject);
    }
}
