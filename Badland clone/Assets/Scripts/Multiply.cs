using UnityEngine;

public class Multiply : MonoBehaviour
{
    [SerializeField] GameObject characterPrefab;
    [SerializeField] Transform characterPos;
    public float multiplyAmount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < multiplyAmount; i++)
        {
            Instantiate(characterPrefab, transform.localPosition, transform.localRotation);
            
        }
        Destroy(gameObject);
    }
}
