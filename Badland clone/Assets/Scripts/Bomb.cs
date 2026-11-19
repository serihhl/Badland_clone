using System.Threading.Tasks;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public float force = 10f;
    public float radius = 8f;

    private void Start() {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        Explosion();

    }

    void Explosion() {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D nearbyObject in colliders) {
            Rigidbody2D rb = nearbyObject.GetComponent<Rigidbody2D>();
            if (rb != null) {
                Vector2 direction = (rb.transform.position - transform.position);
                float distance = direction.magnitude;

                float falloff = 1 - (distance / radius);
                if (falloff > 0) {
                    rb.AddForce(direction.normalized * force * falloff, ForceMode2D.Impulse);
                }
            }
        }

        Destroy(gameObject);

    }

    private void OnDrawGizmos() {

        Gizmos.DrawWireSphere(transform.position, radius);

    }

}
