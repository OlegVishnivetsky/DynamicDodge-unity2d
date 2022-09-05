using TMPro;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    private int _currentScore;
    [SerializeField] private int _bestScore;
    [SerializeField] private TextMeshProUGUI _pointText;
    [SerializeField] private TextMeshProUGUI _bestScoreText;
    [SerializeField] private LevelColorChanger _levelColorChanger;

    private void OnEnable()
    {
        Treat.TreatCollectedEvent += IncreaseAndUpdateScore;
    }

    private void OnDisable()
    {
        Treat.TreatCollectedEvent -= IncreaseAndUpdateScore;
    }

    private void Start()
    {
        if (_bestScoreText != null)
            _bestScoreText.text = "Best: " + PlayerPrefs.GetInt("BestScore").ToString();
        else
            return;
    }

    public void IncreaseAndUpdateScore()
    {
        _currentScore++;
        UpdateScoreText();


        void UpdateScoreText()
        {
            _pointText.text = _currentScore.ToString();

            if (_currentScore % 5 == 0)
                _levelColorChanger.ChangeRandomColor();
        }
    }

    public void SetBestScore()
    {
        if (_currentScore > PlayerPrefs.GetInt("BestScore"))
        {
            _bestScore = _currentScore;
            PlayerPrefs.SetInt("BestScore", _bestScore);
        }
    }
}