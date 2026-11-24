
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToScanner()
    {
        SceneManager.LoadScene("Scanner");
    }

    public void GoToLibrary()
    {
        SceneManager.LoadScene("Library");
    }

    public void GoToAssessment()
    {
        SceneManager.LoadScene("Assessment");
    }

    public void GoToEducation()
    {
        SceneManager.LoadScene("Education");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
