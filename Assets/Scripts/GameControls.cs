using UnityEngine;

public class GameControls : MonoBehaviour
{
    public void ExtPauseGame() => PauseController.Instance.PauseGame();
}
