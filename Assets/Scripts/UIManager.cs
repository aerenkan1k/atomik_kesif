using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static int lives = 3;
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

}
