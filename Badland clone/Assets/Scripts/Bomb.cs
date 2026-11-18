using System.Threading.Tasks;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public float force = 10f;
    public Vector2 direction = Vector2.up;
    public GameObject cha;
    public Rigidbody2D rb;

    private void Start() {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        Explosion();
        Destroy(gameObject);

    }

    void Explosion() {

        rb.AddForce(direction * force);

    }

}
