using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    static MenuManager Instance;
    void Start()
    {
        if(!Instance)
        {
            Instance = this;

            DontDestroyOnLoad(this);
        }

    }
}
