using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Serialised Variables
    [SerializeField] private string playScene;

    // Play Button
    public void PlayButton()
    {
        SceneManager.LoadSceneAsync(playScene);
    }

    // Exit Button
    public void ExitButton()
    {
        Application.Quit();
    }
}
