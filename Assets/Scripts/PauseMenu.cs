using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private void Start()
    {
        PauseController.Instance.RegisterPauseMenu(GetComponent<Canvas>());
    }

    public void ExtResumeGame() => PauseController.Instance.ResumeGame();

    public void ExtQuitToMenu() => GameManager.Instance.SwitchSceneManual("MainMenu");
}
