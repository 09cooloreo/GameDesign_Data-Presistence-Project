using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameHolder : MonoBehaviour
{
    public static NameHolder Instance;

    public string Name;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
