using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{

    public Canvas Menu;
    public Canvas Credits;

    private void Start()
    {
        Credits.enabled = false;
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void ShowCredits()
    {
        Credits.enabled = true;
        Menu.enabled = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
