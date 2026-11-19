using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float distanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer lineRenderer;
    Transform laserTransform;

    private void Awake()
    {
        laserTransform = GetComponent<Transform>();
    }
    private void Update()
    {
        ShootLaser();
    }
    void ShootLaser()
    {
        if(Physics2D.Raycast(laserTransform.position, transform.right))
        {
            RaycastHit2D _hit = Physics2D.Raycast(laserTransform.position, transform.right);
            Draw2DRay(laserFirePoint.position, _hit.point);
        }
        else
        {
            Draw2DRay(laserFirePoint.position, laserFirePoint.transform.right * distanceRay);
        }
    }
    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        lineRenderer.SetPosition(0, startPos);
        lineRenderer.SetPosition(1, endPos);
    }
}
