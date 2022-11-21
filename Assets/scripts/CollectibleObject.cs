using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollectibleObject : MonoBehaviour
{

    [SerializeField] public int mapPiecesLeft = 5;
    [SerializeField] private TMPro.TMP_Text mapPiecesLeftText;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Collectible"))
        {
            
            Destroy(collision.gameObject);
            mapPiecesLeft--;
            mapPiecesLeftText.text = "Map Pieces left: " + mapPiecesLeft;
        }
        gameState();
    }

    private void gameState()
    {
        if(mapPiecesLeft == 0)
        {
            //Yet to be implemented
            //SceneManager.LoadScene("Winning scene");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
