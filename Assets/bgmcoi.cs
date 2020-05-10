using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmcoi : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}