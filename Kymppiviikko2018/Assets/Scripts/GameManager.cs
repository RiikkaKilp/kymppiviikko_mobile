using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public void RestartScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
