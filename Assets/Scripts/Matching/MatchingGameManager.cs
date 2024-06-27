using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MatchingGameManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject winPanel;
    public GameObject gameOverPanel;
    public AudioSource audioSource;
    [Header("Pause Button")]
    public GameObject pauseBtn;
    public Sprite resumeSprite;
    public Sprite pauseSprite;
    private bool isPaused = false;
    [Header("Sound Button")]
    public GameObject soundBtn;
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;
    private bool isSoundOn = true;

    private void Start() 
    {
        pausePanel.SetActive(false);
        winPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
        DropZone.droppedObjects.Clear();
    }
    private void Update() {

        if(!isPaused)
        {
            pauseBtn.GetComponent<Image>().sprite = resumeSprite;
        }
        else
        {
            pauseBtn.GetComponent<Image>().sprite = pauseSprite;
        }

        if(isSoundOn)
        {
            soundBtn.GetComponent<Image>().sprite = soundOnSprite;
        }
        else
        {
            soundBtn.GetComponent<Image>().sprite = soundOffSprite;
        }

        if(DropZone.droppedObjects.Count >= 5)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if(DropZone.isGameOver)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            DropZone.isGameOver = false;
        }
    }
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void OnOffAudio()
    {
        isSoundOn = !isSoundOn;
        audioSource.mute = !audioSource.mute;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        winPanel.SetActive(false);
    }
    public void NextLevelBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DropZone.droppedObjects.Clear();
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
