using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCollision : MonoBehaviour
{
    private int deathCount;
    [SerializeField] Text deathCountText;
    [SerializeField] private Vector2 startingPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            deathCount++;
            deathCountText.text = "Deaths: " + deathCount;
            gameObject.transform.position = startingPos;
        }
    }
}
