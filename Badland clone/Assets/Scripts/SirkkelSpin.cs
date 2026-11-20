using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 10f;
    public Collider2D collider;

    
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime * speed);
        collider.transform.Rotate(0, 0, 50 * Time.deltaTime * speed);
    }
   
}
