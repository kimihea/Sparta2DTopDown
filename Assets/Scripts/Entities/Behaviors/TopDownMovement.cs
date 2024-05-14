using System;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //실제로 이동이 일어날 컴포넌트
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    private CharacterStatHandler characterStatHandler;
    private Vector2 movementDirection= Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        characterStatHandler = GetComponent<CharacterStatHandler>();
    }
    private void Start()
    {
        controller.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }
    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * characterStatHandler.CurrentStat.speed;
        movementRigidbody.velocity = direction;
    }
}
