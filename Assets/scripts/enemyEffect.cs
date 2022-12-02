using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyEffect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
