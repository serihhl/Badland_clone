using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Camera : MonoBehaviour
{
    public float Speed = 1f;
    public Vector3 Direction = Vector3.right;

    private void Update() {

        transform.localPosition = Direction * Speed;

    }
}
