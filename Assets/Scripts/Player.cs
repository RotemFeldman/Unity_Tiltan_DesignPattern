using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public Rigidbody2D Rb;
    public float Speed;
    public IState CurrentState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        CurrentState = new Walking();
    }

    private void Update()
    {
        CurrentState.Update();
    }
}

public interface IState
{
    void Update();
}
