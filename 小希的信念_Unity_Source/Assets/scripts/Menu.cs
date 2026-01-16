using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    //public AudioMixer audioMixer;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Next2Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Next3Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Next4Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Next5Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);

    }
    public void Next6Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void ReturnGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void UIEnable()
    {
        GameObject.Find("Canvas/Menu/UI").SetActive(true);
    }
    //public void PauseGame()
    //{
    //    pauseMenu.SetActive(true);
    //    Time.timeScale = 0f;
    //}
    //public void ResumeGame()
    //{
    //   pauseMenu.SetActive(false);
    //    Time.timeScale = 1f;
    //}
    //public void SetVolume(float value)
    //{
    //    audioMixer.Set
    //}
}
