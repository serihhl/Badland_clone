using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 10f;

    
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime * speed);
    }
   
}
