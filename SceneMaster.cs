using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMaster : MonoBehaviour
{
    private Scene currentScene;
    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
    }
    private void Update()
    {
        if (currentScene.name.Equals("Instructions")) {
            if (Input.GetKeyDown(KeyCode.X)) {
                SceneManager.LoadScene("Main");
            }
        }
        if (currentScene.name.Equals("Game Over")) {
            if (Input.GetKeyDown(KeyCode.C)) {
                SceneManager.LoadScene("Main");
            }
            if (Input.GetKeyDown(KeyCode.X)) {
                SceneManager.LoadScene("Title");
            }
        }
    }
    public void OnPlayClick() {
        SceneManager.LoadScene("Instructions");
    }

    public void OnQuitClick() {
        Application.Quit();
    }

    public void OnPlayerDeath() {
        SceneManager.LoadScene("Game Over");
    }
}
