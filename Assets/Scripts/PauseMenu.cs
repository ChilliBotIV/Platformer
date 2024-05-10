using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseCanvas;
    public AudioSource menuMusic;
    public AudioSource buttonSound;
    public AudioMixerSnapshot defaultSnapshot;
    public AudioMixerSnapshot menuSnapshot;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }

    }

    void Stop()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        Cursor.lockState = CursorLockMode.None;
        menuMusic.Play();
        menuSnapshot.TransitionTo(1);
    }

    public void Play()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        Cursor.lockState = CursorLockMode.Locked;
        menuMusic.Stop();
        defaultSnapshot.TransitionTo(1);

    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

    }
}
