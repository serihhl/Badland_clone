using UnityEngine;
using System.Collections.Generic;
public class Laser : MonoBehaviour
{
    [SerializeField] float distanceRay = 100;
    public LayerMask hitLayers;
    public Transform laserFirePoint;
    public LineRenderer lineRenderer;
    public Collider2D cd;


    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.useWorldSpace = true;
    }
    private void Update()
    {
        ShootLaser();
    }
    void ShootLaser()
    {
        var result = Physics2D.Raycast(laserFirePoint.position, transform.up, distanceRay, hitLayers);
        if (result.collider != null)
        {
            lineRenderer.SetPosition(1, result.point);
        }
        else
        {
            lineRenderer.SetPosition(1, laserFirePoint.position + transform.up * 100);
        }
    }
}
