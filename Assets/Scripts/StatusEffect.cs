﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class StatusEffect : MonoBehaviour
{

    public static void InflictStatusEnemy(string status, int e, int x)
    {

        string identity = "E" + e;
        //checks if status is already in an enemy status slot
        if (status == PlayerPrefs.GetString(identity + "Status" + 0))
        {
            PlayerPrefs.SetInt(identity + "Status" + 0 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status0X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 0 + "X").ToString();
        }
        else if (status == PlayerPrefs.GetString(identity + "Status" + 1))
        {
            PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status1X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
        }
        else if (status == PlayerPrefs.GetString(identity + "Status" + 2))
        {
            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status2X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
        }
        else if (status == PlayerPrefs.GetString(identity + "Status" + 3))
        {
            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status3X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
        }
        else
        {

            if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 && 
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, status);
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", x);
                statusSlot = GameObject.Find(identity + "Status2");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status2X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, status);
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status3");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {

            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 1);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 1));
                statusSlotX = GameObject.Find(identity + "Status1X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 1);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 1));
                statusSlotX = GameObject.Find(identity + "Status1X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, status);
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", x);
                statusSlot = GameObject.Find(identity + "Status2");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status2X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, status);
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status2");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 1);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 1));
                statusSlotX = GameObject.Find(identity + "Status1X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
        }
    }

    public static void InflictStatusCharacter(string status, int p, int x)
    {
        string identity = "P" + p;
        //checks if status is already in an character status slot
        if (status == PlayerPrefs.GetString(identity + "Status" + 0))
        {
            PlayerPrefs.SetInt(identity + "Status" + 0 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status0X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 0 + "X").ToString();
        }
        else if (status == PlayerPrefs.GetString(identity + "Status" + 1))
        {
            PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status1X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
        }
        else if (status == PlayerPrefs.GetString(identity + "Status" + 2))
        {
            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status2X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
        }
        else if (status == PlayerPrefs.GetString(identity + "Status" + 3))
        {
            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X") + x);
            GameObject statusSlotX = GameObject.Find(identity + "Status3X");
            statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
        }
        else
        {

            if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, status);
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", x);
                statusSlot = GameObject.Find(identity + "Status2");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status2X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, status);
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status3");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {

            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 1);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 1));
                statusSlotX = GameObject.Find(identity + "Status1X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 1);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 1));
                statusSlotX = GameObject.Find(identity + "Status1X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, status);
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", x);
                statusSlot = GameObject.Find(identity + "Status2");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status2X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 0)
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 0 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 1, status);
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status1");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status1X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else if (PlayerPrefs.GetInt(identity + "Status" + 0 + "Lock") == 1 && PlayerPrefs.GetInt(identity + "Status" + 1 + "Lock") == 1 &&
                PlayerPrefs.GetInt(identity + "Status" + 2 + "Lock") == 0 && PlayerPrefs.GetInt(identity + "Status" + 3 + "Lock") == 1)
            {
                PlayerPrefs.SetString(identity + "Status" + 2, status);
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", x);
                GameObject statusSlot = GameObject.Find(identity + "Status2");
                LoadSprite.FindSprite(statusSlot, status);
                GameObject statusSlotX = GameObject.Find(identity + "Status2X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
            else
            {
                PlayerPrefs.SetString(identity + "Status" + 3, PlayerPrefs.GetString(identity + "Status" + 2));
                PlayerPrefs.SetInt(identity + "Status" + 3 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                GameObject statusSlot = GameObject.Find(identity + "Status" + 3);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 3));
                GameObject statusSlotX = GameObject.Find(identity + "Status3X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 3 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 1));
                PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 2);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 2));
                statusSlotX = GameObject.Find(identity + "Status2X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 2 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 0));
                PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 0 + "X"));
                statusSlot = GameObject.Find(identity + "Status" + 1);
                LoadSprite.FindSprite(statusSlot, PlayerPrefs.GetString(identity + "Status" + 1));
                statusSlotX = GameObject.Find(identity + "Status1X");
                statusSlotX.GetComponent<Text>().text = PlayerPrefs.GetInt(identity + "Status" + 1 + "X").ToString();
                PlayerPrefs.SetString(identity + "Status" + 0, status);
                PlayerPrefs.SetInt(identity + "Status" + 0 + "X", x);
                statusSlot = GameObject.Find(identity + "Status0");
                LoadSprite.FindSprite(statusSlot, status);
                statusSlotX = GameObject.Find(identity + "Status0X");
                string xText = x.ToString();
                statusSlotX.GetComponent<Text>().text = xText;
            }
        }
    }

    public static void StatusLockEnemy(string status, int e)
    {
        if (PlayerPrefs.GetString("E" + e + "-Status0") == status)
        {
            PlayerPrefs.SetInt("E" + e + "-Status0Lock", 1);
        }
        if (PlayerPrefs.GetString("E" + e + "-Status1") == status)
        {
            PlayerPrefs.SetInt("E" + e + "-Status1Lock", 1);
        }
        if (PlayerPrefs.GetString("E" + e + "-Status2") == status)
        {
            PlayerPrefs.SetInt("E" + e + "-Status2Lock", 1);
        }
        if (PlayerPrefs.GetString("E" + e + "-Status3") == status)
        {
            PlayerPrefs.SetInt("E" + e + "-Status3Lock", 1);
        }
    }

    public static void StatusLockCharacter(string status, int p)
    {
        if (PlayerPrefs.GetString("P" + p + "-Status0") == status)
        {
            PlayerPrefs.SetInt("P" + p + "-Status0Lock", 1);
        }
        if (PlayerPrefs.GetString("P" + p + "-Status1") == status)
        {
            PlayerPrefs.SetInt("P" + p + "-Status1Lock", 1);
        }
        if (PlayerPrefs.GetString("P" + p + "-Status2") == status)
        {
            PlayerPrefs.SetInt("P" + p + "-Status2Lock", 1);
        }
        if (PlayerPrefs.GetString("P" + p + "-Status3") == status)
        {
            PlayerPrefs.SetInt("P" + p + "-Status3Lock", 1);
        }
    }

    public static void StatusTickEnd(string identity)
    {
        for (int b = 0; b <= 3; b++)
        {
            switch (PlayerPrefs.GetString(identity + "Status" + b))
            {

                case "null":
                    {
                        GameObject statusSlotX = GameObject.Find(identity + "Status" + b + "X");
                        statusSlotX.GetComponent<Text>().text = "";
                        GameObject statusIcon = GameObject.Find(identity + "Status" + b);
                        LoadSprite.FindSprite(statusIcon, "none");
                        if (b == 0)
                        {
                            PlayerPrefs.SetString(identity + "Status" + 0, PlayerPrefs.GetString(identity + "Status" + 1));
                            PlayerPrefs.SetInt(identity + "Status" + 0 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 2));
                            PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 3));
                            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 3, "null");
                            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", 0);
                        }
                        if (b == 1)
                        {
                            PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 2));
                            PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 3));
                            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 3, "null");
                            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", 0);
                        }
                        if (b == 2)
                        {
                            PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 3));
                            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 3, "null");
                            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", 0);
                        }
                        break;
                    }
                case "poison":
                    {

                        int x = PlayerPrefs.GetInt(identity + "Status" + b + "X");
                        int PHP = PlayerPrefs.GetInt(identity + "-CHP");
                        int xDamage = x;
                        if (PlayerPrefs.GetString(identity + "-Weakness1") == "Toxic" || PlayerPrefs.GetString(identity + "-Weakness2") == "Toxic")
                        {
                            xDamage = (int)Math.Round((float)xDamage * 1.5, 1);
                        }
                        if (PlayerPrefs.GetString(identity + "-Resistance1") == "Toxic" || PlayerPrefs.GetString(identity + "-Resistance2") == "Toxic" || PlayerPrefs.GetString(identity + "-Resistance3") == "Toxic")
                        {
                            xDamage = (int)Math.Round((float)xDamage * 0.75, 1);
                        }
                        int PCHP = PHP - xDamage;
                        PlayerPrefs.SetInt(identity + "-CHP", PCHP);
                        GameObject Bar = GameObject.Find(identity + "-Hp");
                        if (PCHP > 0)
                        {
                            PlayerPrefs.SetInt(identity + "-CHP", PCHP);
                            int E1Max = PlayerPrefs.GetInt(identity + "-HP");
                            float PercentHP = ((float)PCHP / (float)E1Max);
                            Bar.gameObject.transform.localScale = new UnityEngine.Vector3(PercentHP, 1, 1);
                        }
                        else
                        {
                            if (identity[0] == 'P')
                            {
                                GameObject player = GameObject.Find(PlayerPrefs.GetString(identity + "-Name"));
                                player.GetComponent<SpriteRenderer>().color = Color.black;
                                if (PlayerPrefs.GetInt("P1-CHP") == 0 && PlayerPrefs.GetInt("P2-CHP") == 0)
                                {
                                    Application.LoadLevel("GameOver");
                                }
                                PCHP = 0;
                            }
                            else
                            {
                                PlayerPrefs.SetInt(identity + "-CHP", 0);
                                int E1Max = PlayerPrefs.GetInt(identity + "-HP");
                                float PercentHP = ((float)0 / (float)E1Max);
                                Bar.gameObject.transform.localScale = new Vector3(PercentHP, 1, 1);
                                GameObject enemy = GameObject.Find(identity);
                                enemy.GetComponent<SpriteRenderer>().color = Color.black;
                                if (PlayerPrefs.GetInt("E1-HP") <= 0 && PlayerPrefs.GetInt("E2-HP") <= 0)
                                {
                                    //change to map
                                    Application.LoadLevel("Win");
                                    PlayerPrefs.SetInt("E1-Set", 0);
                                }
                                else if (PlayerPrefs.GetInt("E1-HP") <= 0 && PlayerPrefs.GetString("E2-Name") == "null")
                                {
                                    //change to map
                                    Application.LoadLevel("Win");
                                    PlayerPrefs.SetInt("E1-Set", 0);
                                }
                                GiveTurn();
                            }
                        }
                        x--;
                        GameObject statusSlotX = GameObject.Find(identity + "Status" + b + "X");
                        string xText = x.ToString();
                        statusSlotX.GetComponent<Text>().text = xText;
                        PlayerPrefs.SetInt(identity + "Status" + b + "X", x);
                        if (x <= 0)
                        {
                            PlayerPrefs.SetString(identity + "Status" + b, "null");
                            b--;
                        }
                        break;
                    }
                case "burning":
                    {
                        int x = PlayerPrefs.GetInt(identity + "Status" + b + "X");
                        int PHP = PlayerPrefs.GetInt(identity + "-CHP");
                        int PGuard = PlayerPrefs.GetInt(identity + "-CG");
                        int xDamage = x;
                        if (PlayerPrefs.GetString(identity + "-Weakness1") == "Fire" || PlayerPrefs.GetString(identity + "-Weakness2") == "Fire")
                        {
                            xDamage = (int)Math.Round((float)xDamage * 1.5, 1);
                        }
                        if (PlayerPrefs.GetString(identity + "-Resistance1") == "Fire" || PlayerPrefs.GetString(identity + "-Resistance2") == "Fire" || PlayerPrefs.GetString(identity + "-Resistance3") == "Fire")
                        {
                            xDamage = (int)Math.Round((float)xDamage * 0.75, 1);
                        }
                        PGuard = PGuard - ((xDamage / 2) + (xDamage % 2));
                        if (PGuard < 0)
                        {
                            PHP = PHP + PGuard;
                            PGuard = 0;
                        }
                        PHP = PHP - xDamage / 2;
                        PlayerPrefs.SetInt(identity + "-CHP", PHP);
                        GameObject Bar = GameObject.Find(identity + "-Hp");
                        GameObject GBar = GameObject.Find(identity + "-Guard");
                        PlayerPrefs.SetInt(identity + "-CG", PGuard);
                        int E1MaxG = PlayerPrefs.GetInt(identity + "-Guard");
                        float PercentG = ((float)PGuard / (float)E1MaxG);
                        GBar.gameObject.transform.localScale = new Vector3(PercentG, 1, 1);
                        if (PHP > 0)
                        {
                            PlayerPrefs.SetInt(identity + "-CHP", PHP);
                            int E1Max = PlayerPrefs.GetInt(identity + "-HP");
                            float PercentHP = ((float)PHP / (float)E1Max);
                            Bar.gameObject.transform.localScale = new UnityEngine.Vector3(PercentHP, 1, 1);
                        }
                        else
                        {
                            if (identity[0] == 'P')
                            {
                                GameObject player = GameObject.Find(PlayerPrefs.GetString(identity + "-Name"));
                                player.GetComponent<SpriteRenderer>().color = Color.black;
                                if (PlayerPrefs.GetInt("P1-CHP") == 0 && PlayerPrefs.GetInt("P2-CHP") == 0)
                                {
                                    Application.LoadLevel("GameOver");
                                }
                                PHP = 0;
                            }
                            else
                            {
                                PlayerPrefs.SetInt(identity + "-CHP", 0);
                                int E1Max = PlayerPrefs.GetInt(identity + "-HP");
                                float PercentHP = ((float)0 / (float)E1Max);
                                Bar.gameObject.transform.localScale = new Vector3(PercentHP, 1, 1);
                                GameObject enemy = GameObject.Find(identity);
                                enemy.GetComponent<SpriteRenderer>().color = Color.black;
                                if (PlayerPrefs.GetInt("E1-HP") <= 0 && PlayerPrefs.GetInt("E2-HP") <= 0)
                                {
                                    //change to map
                                    Application.LoadLevel("Win");
                                    PlayerPrefs.SetInt("E1-Set", 0);
                                }
                                else if (PlayerPrefs.GetInt("E1-HP") <= 0 && PlayerPrefs.GetString("E2-Name") == "null")
                                {
                                    //change to map
                                    Application.LoadLevel("Win");
                                    PlayerPrefs.SetInt("E1-Set", 0);
                                }
                                GiveTurn();
                            }
                        }
                        x++;
                        GameObject statusSlotX = GameObject.Find(identity + "Status" + b + "X");
                        string xText = x.ToString();
                        statusSlotX.GetComponent<Text>().text = xText;
                        PlayerPrefs.SetInt(identity + "Status" + b + "X", x);
                        if (x <= 0)
                        {
                            PlayerPrefs.SetString(identity + "Status" + b, "null");
                            b--;
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }

    public static void StatusTickStart(string identity)
    {
        for (int b = 0; b <= 3; b++)
        {
            switch (PlayerPrefs.GetString(identity + "Status" + b))
            {

                case "null":
                    {
                        GameObject statusSlotX = GameObject.Find(identity + "Status" + b + "X");
                        statusSlotX.GetComponent<Text>().text = "";
                        GameObject statusIcon = GameObject.Find(identity + "Status" + b);
                        LoadSprite.FindSprite(statusIcon, "none");
                        if (b == 0)
                        {
                            PlayerPrefs.SetString(identity + "Status" + 0, PlayerPrefs.GetString(identity + "Status" + 1));
                            PlayerPrefs.SetInt(identity + "Status" + 0 + "X", PlayerPrefs.GetInt(identity + "Status" + 1 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 2));
                            PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 3));
                            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 3, "null");
                            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", 0);
                        }
                        if (b == 1)
                        {
                            PlayerPrefs.SetString(identity + "Status" + 1, PlayerPrefs.GetString(identity + "Status" + 2));
                            PlayerPrefs.SetInt(identity + "Status" + 1 + "X", PlayerPrefs.GetInt(identity + "Status" + 2 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 3));
                            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 3, "null");
                            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", 0);
                        }
                        if (b == 2)
                        {
                            PlayerPrefs.SetString(identity + "Status" + 2, PlayerPrefs.GetString(identity + "Status" + 3));
                            PlayerPrefs.SetInt(identity + "Status" + 2 + "X", PlayerPrefs.GetInt(identity + "Status" + 3 + "X"));
                            PlayerPrefs.SetString(identity + "Status" + 3, "null");
                            PlayerPrefs.SetInt(identity + "Status" + 3 + "X", 0);
                        }
                        break;
                    }
                case "steadfast":
                    {
                        int x = PlayerPrefs.GetInt(identity + "Status" + b + "X");
                        x--;
                        GameObject statusSlotX = GameObject.Find(identity + "Status" + b + "X");
                        string xText = x.ToString();
                        statusSlotX.GetComponent<Text>().text = xText;
                        PlayerPrefs.SetInt(identity + "Status" + b + "X", x);
                        if (x <= 0)
                        {
                            PlayerPrefs.SetString(identity + "Status" + b, "null");
                            b--;
                        }
                        break;
                    }
                case "vulnerable":
                    {
                        int x = PlayerPrefs.GetInt(identity + "Status" + b + "X");
                        x--;
                        GameObject statusSlotX = GameObject.Find(identity + "Status" + b + "X");
                        string xText = x.ToString();
                        statusSlotX.GetComponent<Text>().text = xText;
                        PlayerPrefs.SetInt(identity + "Status" + b + "X", x);
                        if (x <= 0)
                        {
                            PlayerPrefs.SetString(identity + "Status" + b, "null");
                            b--;
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }

    public static void GiveTurn()
    {
        PlayerPrefs.SetInt("P1-TurnTaken", 0);
        PlayerPrefs.SetInt("P2-TurnTaken", 0);
        PlayerPrefs.SetInt("P3-TurnTaken", 0);
        PlayerPrefs.SetInt("P4-TurnTaken", 0);
        PlayerPrefs.SetInt("P1-CanMove", 1);
        PlayerPrefs.SetInt("P2-CanMove", 1);
        PlayerPrefs.SetInt("P3-CanMove", 1);
        PlayerPrefs.SetInt("P4-CanMove", 1);
        //add more for more players
        GameObject hero = GameObject.Find("P1");
        if (PlayerPrefs.GetInt("P1-CHP") > 0)
        {
            hero.GetComponent<SpriteRenderer>().color = Color.white;
        }
        hero = GameObject.Find("P2");
        if (PlayerPrefs.GetInt("P2-CHP") > 0)
        {
            hero.GetComponent<SpriteRenderer>().color = Color.white;
        }
        GameObject PDiss = GameObject.Find("PDiss");
        PDiss.transform.position = new Vector3(-3000, 0, 0);
        GameObject PlayerTurn = GameObject.Find("PlayerTurn");
        PlayerTurn.GetComponent<PlayerTurn>().Begin();
    }
}