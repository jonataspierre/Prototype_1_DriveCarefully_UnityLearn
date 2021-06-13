using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class UI : MonoBehaviour
{
    public GameObject winPlayer1;
    public GameObject winPlayer2;
    
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("GameManager"))
        {
            if (GameManager.gameManager.winnerPlayer == "Player_1")
            {
                winPlayer1.SetActive(true);
            }
            else if (GameManager.gameManager.winnerPlayer == "Player_2")
            {
                winPlayer2.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }   
    }

    public void Play(int btnIndex)
    {
        Destroy(GameObject.Find("GameManager"));

        switch (btnIndex)
        {
            case 1:
                SceneManager.LoadScene(1);
                break;
            
            case 2:
                SceneManager.LoadScene(2);
                break;

            case 3:
                SceneManager.LoadScene(3);
                break;

            case 4:
                SceneManager.LoadScene(4);
                break;
        }
    }
}
