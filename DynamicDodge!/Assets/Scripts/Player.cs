using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [Header("Movement Settings")]
    [SerializeField] private float _jumpVelocity;

    private Camera _cameraCache;

    private void Awake()
    {
        _cameraCache = Camera.main;
        _rigidbody2D.gravityScale = 0;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            BouncePlayer();
        }
    }

    private void BouncePlayer()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = _cameraCache.ScreenToWorldPoint(touch.position);

        if(touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved && _rigidbody2D.gravityScale != 0)
           _rigidbody2D.velocity = new Vector2(touchPosition.x / Mathf.Abs(touchPosition.x), 1) * _jumpVelocity;
    }
}