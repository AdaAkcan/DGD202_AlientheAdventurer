using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Add to inventory
            Inventory.instance.AddCoin();
            Destroy(gameObject);
        }
    }
}
//This code is generated with AI