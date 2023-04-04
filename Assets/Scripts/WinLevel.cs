using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLevel : MonoBehaviour
{
    [SerializeField] Text winText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            winText.gameObject.SetActive(true);
        }
    }
}
