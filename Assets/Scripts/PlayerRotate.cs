using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerRenderer;

    private PlayerController _controller;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotatePlayer(newAimDirection);
    }

    private void RotatePlayer(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;//아크 탄젠트 값을 라디안 값으로 반환하므로 degree 값으로 바꾸어 줘야한다.
        playerRenderer.flipX = Mathf.Abs(rotZ) > 90f;

    }
}
