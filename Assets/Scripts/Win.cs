using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    //public string winnerPlayer;
    //public bool win;

    public static Win winController;
    
    // Start is called before the first frame update
    void Start()
    {
        winController = this;
        //win = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {            
            GameManager.gameManager.winnerPlayer = (collision.gameObject.name);
            GameManager.gameManager.win = true; 
            StartCoroutine(sceneLoad());            
        }
    }

    private IEnumerator sceneLoad()
    {
        yield return new WaitForSeconds(1.5f);

        DontDestroyOnLoad(GameManager.gameManager.gameObject);
        SceneManager.LoadScene(0);
    }
}
