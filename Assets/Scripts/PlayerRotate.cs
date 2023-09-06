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
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;//��ũ ź��Ʈ ���� ���� ������ ��ȯ�ϹǷ� degree ������ �ٲپ� ����Ѵ�.
        playerRenderer.flipX = Mathf.Abs(rotZ) > 90f;

    }
}
