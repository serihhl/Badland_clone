using UnityEngine;

public class Multiply : MonoBehaviour
{
    [SerializeField] GameObject characterPrefab;
    public float multiplyAmount;
    [SerializeField] Transform position;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < multiplyAmount; i++)
        {
           Instantiate(characterPrefab);
        }
    }
}
