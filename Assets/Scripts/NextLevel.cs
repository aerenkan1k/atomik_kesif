using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private Scene scene;
    private int? nextScene;
    private void Awake()
    {
        scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            nextScene = scene.buildIndex + 1;
            if (nextScene is not null)
            {
                SceneManager.LoadScene((int)nextScene);
            }
        }
    }
}
