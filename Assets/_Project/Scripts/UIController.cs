using UnityEngine;

public class UIController : GenericSingleton<UIController>
{
    public GameObject PauseGamePanel;
    public GameObject GameOverPanel;
    public GameObject LevelUP;

    public void ShowGameOver()
    {
        GameOverPanel.SetActive(true);
    }

    public void HideGameOver()
    {
        GameOverPanel.SetActive(false);
    }

    public void ShowPausePanel()
    {
        PauseGamePanel.SetActive(true);
    }

    public void HidePausePanel()
    {
        PauseGamePanel.SetActive(false);
    }
    public void OpenSettingsPanel()
    {

    }
}
