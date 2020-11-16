using UnityEngine;
public class Pause : MonoBehaviour
{
    bool _paused;
    public GameObject PausePanel;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SwitchPause();
        }
    }
    public void SwitchPause()
    {
        Time.timeScale = (!_paused) ? 0 : 1;
        _paused = !_paused;
        PausePanel.SetActive(_paused);
    }
}