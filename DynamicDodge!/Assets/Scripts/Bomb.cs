using UnityEngine;

public class Bomb : MonoBehaviour
{
    [Header("Tweens Components")]
    [SerializeField] private TweenScaleAnimation _tweenScaleAnimation;
    [Header("Other Components")]
    [SerializeField] private Border _border;

    private void Start()
    {
        _tweenScaleAnimation.TweenScaleIn();

        _border = FindObjectOfType<Border>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>())
        {
            _border.GameOverActions();
        }
    }
}