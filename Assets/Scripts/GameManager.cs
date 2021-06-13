using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int numPlayers;
    public bool win;
    public string winnerPlayer;

    public static GameManager gameManager;
        
    // Start is called before the first frame update
    void Start()
    {
        gameManager = this;
        win = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacles"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            if (!win)
            {            
                if (SceneManager.GetActiveScene().buildIndex != 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else
                {
                    numPlayers += 1;
                    
                    if (numPlayers == 2)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                    else
                    {
                        other.gameObject.SetActive(false);
                    }
                }
            }            
        }
    }    
}
