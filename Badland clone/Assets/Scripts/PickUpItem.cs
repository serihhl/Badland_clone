using UnityEngine;

public enum PickUpItemType { None, BiggerChar, SmallerChar }

public class PickUpItems : MonoBehaviour
{
    public PickUpItemType WhichItem;

    private void OnTriggerEnter2D(Collider2D collision) {

        FindAnyObjectByType<GameManager>().PickUpActivated(WhichItem);
        Destroy(gameObject);

    }
}
