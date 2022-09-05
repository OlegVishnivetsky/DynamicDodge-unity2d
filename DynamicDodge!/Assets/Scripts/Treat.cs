using System;
using UnityEngine;

public class Treat : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TweenScaleAnimation _tweenScaleAnimation;

    public static event Action TreatCollectedEvent;

    [Header("Range spawn X position")]
    [SerializeField] private float _maxXSapwnPosition;
    [SerializeField] private float _minXSapwnPosition;
    [Header("Range spawn Y position")]
    [SerializeField] private float _maxYSapwnPosition;
    [SerializeField] private float _minYSapwnPosition;

    private void Start()
    {
        _tweenScaleAnimation.TweenScaleIn();
        gameObject.SetActive(false);

        GenerateRandomPosition();
    }

    private void GenerateRandomPosition()
    {
        transform.position = new Vector2(UnityEngine.Random.Range(_minXSapwnPosition, _maxXSapwnPosition), UnityEngine.Random.Range(_maxYSapwnPosition, _minYSapwnPosition));
        _tweenScaleAnimation.TweenScaleIn();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_player != null)
        {
            TreatCollectedEvent?.Invoke();
            GenerateRandomPosition();
        }
    }
}