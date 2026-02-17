using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class movement : MonoBehaviour
{
    public Input InputActions;

    private InputAction m_KeyboardAction;

    private Vector2 m_KeyboardAmt;
    private Animator m_animator;
    private Rigidbody m_rigidbody;

    public float WalkSpeed = 5;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();

    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }
}
