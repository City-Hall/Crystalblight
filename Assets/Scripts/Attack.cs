﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    public Text textbox;
    public GameObject InputDiss;
    public unclick unclick;

    void OnMouseDown()
    {
        // move input dissable over the players then find out who is attacking and let the player choose who to attack
        int p = 0;
        if (PlayerPrefs.GetInt("P1-Clicked") == 1)
        {
            p = 1;
        }
        else if (PlayerPrefs.GetInt("P2-Clicked") == 1)
        {
            p = 2;
        }
        else if (PlayerPrefs.GetInt("P3-Clicked") == 1)
        {
            p = 3;
        }
        else if (PlayerPrefs.GetInt("P4-Clicked") == 1)
        {
            p = 4;
        }
        unclick.OnMouseDown();
        PlayerPrefs.SetString("ActiveSkill", GameObject.Find("A-Text").GetComponent<Text>().text);
        textbox.text = "Choose target for attack";
        GameObject PDiss = GameObject.Find("PDiss");
        PDiss.transform.position = new Vector3(-500, 0, -100);
        PlayerPrefs.SetInt("P"+p+"-Targeting", 1);
    }
}
