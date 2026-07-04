using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerButtons : MonoBehaviour
{
    public void Sale(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void CreateTeam(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Teams(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
