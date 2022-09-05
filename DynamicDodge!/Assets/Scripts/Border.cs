using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Border : MonoBehaviour
{
    [Header("PointControl Component")]
    [SerializeField] private ScoreControl _pointControl;
    [Header("Float Parameters")]
    [SerializeField] private float _timeToChangeScene;
    private bool _isGameOver;

    private void Awake()
    {
        _isGameOver = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>())
        {
            GameOverActions();
        }
    }

    private IEnumerator TransitionToMenuScene()
    {
        yield return new WaitForSeconds(_timeToChangeScene / 2);
        SceneManager.LoadSceneAsync(0);
    }

    public void GameOverActions()
    {
        if (_isGameOver)
        {
            _isGameOver = false;

            Handheld.Vibrate();
            Time.timeScale = 0.5f;
            _pointControl.SetBestScore();
            StartCoroutine(TransitionToMenuScene());
        }
    }
}