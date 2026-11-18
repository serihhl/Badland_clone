using UnityEngine;

public class Bomb : MonoBehaviour
{
    Rigidbody2D rb;
    public float force = 10f;
    public Vector2 direction = Vector2.up;

    private void OnTriggerEnter2D(Collider2D collision) {

        rb.AddForce(direction * force);
        Destroy(gameObject);

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
