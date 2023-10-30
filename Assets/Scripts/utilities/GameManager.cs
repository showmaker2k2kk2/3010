using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class GameManager : MonoBehaviour
{
    public Player player;
    public static GameManager Intance;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Intance = null)
            Intance = this;
    }
}
