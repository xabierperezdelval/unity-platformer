using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    private int itemsCollected;
    [SerializeField] Text itemsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item")) {
            Destroy(collision.gameObject);
            itemsCollected++;
            itemsText.text = "Items collected: " + itemsCollected;
        }
    }
}
