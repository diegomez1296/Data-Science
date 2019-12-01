using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public Vector2[] inputs;

    public static Inputs Instance;

    private void Start()
    {
        if (Instance == null)
            Instance = FindObjectOfType<Inputs>();
    }
}
