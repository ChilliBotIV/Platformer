using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource buttonSound;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Level-1");
        buttonSound.Play();
        DontDestroyOnLoad(buttonSound.gameObject);
        
    }

    public void QuitGame()
    {
        Application.Quit();
        buttonSound.Play();
        DontDestroyOnLoad(buttonSound.gameObject);

    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
        buttonSound.Play();
        DontDestroyOnLoad(buttonSound.gameObject);

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        buttonSound.Play();
        DontDestroyOnLoad(buttonSound.gameObject);

    }
}
