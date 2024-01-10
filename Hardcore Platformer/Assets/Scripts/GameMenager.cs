using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameMenager : MonoBehaviour
{
    public KeyCode restartKey = KeyCode.R;
    public GameObject player;
    public TMP_Text deathText;

    private void Update()
    {
        
        if (player == null)
        {
            
            deathText.gameObject.SetActive(true);
        }
        else
        {
            
            deathText.gameObject.SetActive(false);

            
            
        }
        if (Input.GetKeyDown(restartKey))
            {
                RestartScene();
            }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
