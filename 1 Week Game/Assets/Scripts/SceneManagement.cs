using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public GameObject goodButton, badButton, canvas;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
        }
    }

    public void goodOption()
    {
        if (sceneName == "Starting Scene")
        {
            SceneManager.LoadScene(2);
        }

        if (sceneName == "1Good")
        {
            SceneManager.LoadScene(4);
        }

        if (sceneName == "2Good")
        {
            SceneManager.LoadScene(5);
        }

        if (sceneName == "1Bad")
        {
            SceneManager.LoadScene(4);
        }

        if (sceneName == "2Bad")
        {
            SceneManager.LoadScene(5);
        }
    }

    public void badOption()
    {
        if (sceneName == "Starting Scene")
        {
            SceneManager.LoadScene(1);
        }

        if (sceneName == "1Good")
        {
            SceneManager.LoadScene(3);
        }

        if (sceneName == "2Good")
        {
            SceneManager.LoadScene(5);
        }

        if (sceneName == "1Bad")
        {
            SceneManager.LoadScene(3);
        }

        if (sceneName == "2Bad")
        {
            SceneManager.LoadScene(5);
        }
    }
}
