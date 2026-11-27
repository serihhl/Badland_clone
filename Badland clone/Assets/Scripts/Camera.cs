using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Camera : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 direction = Vector3.right;

    private void Update() {

        var p = transform.position;
        p.x = speed * Time.deltaTime;
        transform.position += direction * p.x;

    }
}
