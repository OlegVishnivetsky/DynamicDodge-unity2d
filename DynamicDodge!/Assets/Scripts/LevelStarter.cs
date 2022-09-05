using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelStarter : MonoBehaviour
{
    [SerializeField] private float _delayToChangeScene;
    public UnityEvent StartGameTapButtonPressedEvent;

    private void Awake()
    {
        Application.targetFrameRate = 160;
        Time.timeScale = 1;
    }

    public void OnPlayButton()
    {
        StartCoroutine(TransitionScene());
    }

    private IEnumerator TransitionScene()
    {
        yield return new WaitForSeconds(_delayToChangeScene);
        SceneManager.LoadSceneAsync(1);
    }

    public void OnStartGameTapButton()
    {
        StartGameTapButtonPressedEvent?.Invoke();
    }
}