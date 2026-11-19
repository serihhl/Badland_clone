using UnityEngine;
using System.Collections.Generic;
public class Laser : MonoBehaviour
{
    [SerializeField] float distanceRay = 100;
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
    //    if(Physics2D.Raycast(laserTransform.position, transform.right))
    //    {
    //        RaycastHit2D _hit = Physics2D.Raycast(laserTransform.position, transform.right);
    //        Draw2DRay(laserFirePoint.position, _hit.point);
    //    }
    //    else
    //    {
            Draw2DRay(laserFirePoint.position, laserFirePoint.transform.up * distanceRay);
        //}
    }
    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        startPos = laserFirePoint.transform.position;
        endPos = transform.position * distanceRay;
         
    }
}
