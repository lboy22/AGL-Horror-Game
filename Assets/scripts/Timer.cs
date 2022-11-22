using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    //Starting time for game.
    [SerializeField] public float timer = 5f;
 
    [SerializeField ] private TextMeshProUGUI seconds;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0f)
        {
            timer -= Time.deltaTime;        
        }

        else
        {
            //Load up game over scene.
            //SceneManager.LoadScene('');

            UnityEditor.EditorApplication.isPlaying = false;
        }
        UpdateTimerDisplay(timer);
    }

    private void UpdateTimerDisplay(float time)
    {
        seconds.text = string.Format("{0}", (int)time);
    }
}
