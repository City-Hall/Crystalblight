﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();
    }
}
