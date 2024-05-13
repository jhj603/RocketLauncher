using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<bool> OnBoostEvent;

    private EnergySystem _energySystem;
    private RocketMovement _rocketMovement;
    
    private bool _isMoving;
    private Vector2 _movementDirection;
    
    private void Awake()
    {
        _energySystem = GetComponent<EnergySystem>();
        _rocketMovement = GetComponent<RocketMovement>();
    }

    // TODO : OnMove 구현
    private void OnMove(InputValue value)
    {
        _movementDirection = value.Get<Vector2>().normalized;

        OnMoveEvent?.Invoke(_movementDirection);
    }


    // TODO : OnBoost 구현
    // private void OnBoost...
    private void OnBoost(InputValue value)
    {
        //_rocketMovement.ApplyBoost(value.isPressed);

        OnBoostEvent?.Invoke(value.isPressed);
    }
}