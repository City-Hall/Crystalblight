﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class E3 : MonoBehaviour
{
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        string tile = PlayerPrefs.GetString("CurrentTile");
        string e3Name = "";
        int combatNumber = 0;
        if (tile[0] == 'C')
        {
            if (tile.Length == 7)
            {
                combatNumber = Int32.Parse(tile[6].ToString());
            }
            if (tile.Length == 8)
            {
                combatNumber = Int32.Parse(tile[6].ToString() + tile[7].ToString());
            }
            e3Name = PlayerPrefs.GetString("Combat" + combatNumber + "E3-Name");
        }
        if (tile[0] == 'M')
        {
            e3Name = PlayerPrefs.GetString("MinibossE3-Name");
        }
        if (tile[0] == 'B')
        {
            e3Name = PlayerPrefs.GetString("BossE3-Name");
        }
        if (e3Name != "null")
        {
            PlayerPrefs.SetInt("E-Block-1-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-2-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-3-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-4-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-5-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-6-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-7-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-8-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-9-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-10-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-11-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-12-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-13-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-14-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-15-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-16-Moveable", 1);
            PlayerPrefs.SetInt("E3-Loc", 0);
            Invoke("SetLoc", 0.1f);
            if (PlayerPrefs.GetInt("E3-Set") != 1)
            {
                PlayerPrefs.SetString("E3-Name", e3Name);
                PlayerPrefs.SetInt("E3-CHP", PlayerPrefs.GetInt(e3Name + "-CHP"));
                PlayerPrefs.SetInt("E3-HP", PlayerPrefs.GetInt(e3Name + "-HP"));
                PlayerPrefs.SetInt("E3-CG", PlayerPrefs.GetInt(e3Name + "-CG"));
                PlayerPrefs.SetInt("E3-Guard", PlayerPrefs.GetInt(e3Name + "-Guard"));
                PlayerPrefs.SetInt("E3-Set", 1);
                PlayerPrefs.SetString("E3Status0", PlayerPrefs.GetString(e3Name + "Status0"));
                PlayerPrefs.SetInt("E3Status0X", PlayerPrefs.GetInt(e3Name + "Status0X"));
                PlayerPrefs.SetString("E3Status1", PlayerPrefs.GetString(e3Name + "Status1"));
                PlayerPrefs.SetInt("E3Status1X", PlayerPrefs.GetInt(e3Name + "Status1X"));
                PlayerPrefs.SetString("E3Status2", PlayerPrefs.GetString(e3Name + "Status2"));
                PlayerPrefs.SetInt("E3Status2X", PlayerPrefs.GetInt(e3Name + "Status2X"));
                PlayerPrefs.SetString("E3Status3", PlayerPrefs.GetString(e3Name + "Status3"));
                PlayerPrefs.SetInt("E3Status3X", PlayerPrefs.GetInt(e3Name + "Status3X"));
                PlayerPrefs.SetInt("E3-Attack", PlayerPrefs.GetInt(e3Name + "-Attack"));
                PlayerPrefs.SetString("E3-Weakness1", PlayerPrefs.GetString(e3Name + "-Weakness1"));
                PlayerPrefs.SetString("E3-Weakness2", PlayerPrefs.GetString(e3Name + "-Weakness2"));
                PlayerPrefs.SetString("E3-Resistance1", PlayerPrefs.GetString(e3Name + "-Resistance1"));
                PlayerPrefs.SetString("E3-Resistance3", PlayerPrefs.GetString(e3Name + "-Resistance3"));
                PlayerPrefs.SetString("E3-Resistance3", PlayerPrefs.GetString(e3Name + "-Resistance3"));
                PlayerPrefs.SetString("E3-Skill1", PlayerPrefs.GetString(e3Name + "-Skill1"));
                PlayerPrefs.SetString("E3-Skill2", PlayerPrefs.GetString(e3Name + "-Skill2"));
                PlayerPrefs.SetString("E3-Skill3", PlayerPrefs.GetString(e3Name + "-Skill3"));
                PlayerPrefs.SetString("E3-Skill4", PlayerPrefs.GetString(e3Name + "-Skill4"));
                PlayerPrefs.SetString("E3-Skill5", PlayerPrefs.GetString(e3Name + "-Skill5"));
                PlayerPrefs.SetString("E3-Skill6", PlayerPrefs.GetString(e3Name + "-Skill6"));
                GameObject targetHP = GameObject.Find("E3-Hp");
                int PCHP = PlayerPrefs.GetInt("E3-CHP");
                int PMax = PlayerPrefs.GetInt("E3-HP");
                float Percent = ((float)PCHP / (float)PMax);
                targetHP.gameObject.transform.localScale = new Vector3(Percent, 1, 1);
                GameObject targetGuard = GameObject.Find("E3-Guard");
                int PCGuard = PlayerPrefs.GetInt("E3-CG");
                int PMaxGuard = PlayerPrefs.GetInt("E3-Guard");
                float PercentGuard = ((float)PCGuard / (float)PMaxGuard);
                targetGuard.gameObject.transform.localScale = new Vector3(PercentGuard, 1, 1);
                GameObject sprite = GameObject.Find("E3");
                if (e3Name.Substring(e3Name.Length - 8) == "(Stage1)" || e3Name.Substring(e3Name.Length - 8) == "(Stage2)" || e3Name.Substring(e3Name.Length - 8) == "(Stage3)")
                {
                    e3Name = e3Name.Remove(e3Name.Length - 9, 9);
                }
                LoadSprite.FindSprite(sprite, e3Name);
                BoxCollider2D _boxCollider = GetComponent<BoxCollider2D>();
                Destroy(_boxCollider);
                _boxCollider = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
                // PlayerPrefs.SetInt("E3-Guard", 100);
                PlayerPrefs.SetInt("E3-AttL", 0);
                ChooseAttack();
            }
        }
        if (e3Name == "null")
        {
            PlayerPrefs.SetString("E3-Name", e3Name);
            PlayerPrefs.SetInt("E3-CHP", PlayerPrefs.GetInt(e3Name + "-CHP"));
            PlayerPrefs.SetInt("E3-HP", PlayerPrefs.GetInt(e3Name + "-HP"));
            PlayerPrefs.SetInt("E3-CG", PlayerPrefs.GetInt(e3Name + "-CG"));
            PlayerPrefs.SetInt("E3-Guard", PlayerPrefs.GetInt(e3Name + "-Guard"));
            PlayerPrefs.SetInt("E3-Set", 1);
            PlayerPrefs.SetString("E3Status0", PlayerPrefs.GetString(e3Name + "Status0"));
            PlayerPrefs.SetInt("E3Status0X", PlayerPrefs.GetInt(e3Name + "Status0X"));
            PlayerPrefs.SetString("E3Status1", PlayerPrefs.GetString(e3Name + "Status1"));
            PlayerPrefs.SetInt("E3Status1X", PlayerPrefs.GetInt(e3Name + "Status1X"));
            PlayerPrefs.SetString("E3Status2", PlayerPrefs.GetString(e3Name + "Status2"));
            PlayerPrefs.SetInt("E3Status2X", PlayerPrefs.GetInt(e3Name + "Status2X"));
            PlayerPrefs.SetString("E3Status3", PlayerPrefs.GetString(e3Name + "Status3"));
            PlayerPrefs.SetInt("E3Status3X", PlayerPrefs.GetInt(e3Name + "Status3X"));
            PlayerPrefs.SetInt("E3-Attack", PlayerPrefs.GetInt(e3Name + "-Attack"));
            PlayerPrefs.SetString("E3-Weakness1", PlayerPrefs.GetString(e3Name + "-Weakness1"));
            PlayerPrefs.SetString("E3-Weakness2", PlayerPrefs.GetString(e3Name + "-Weakness2"));
            PlayerPrefs.SetString("E3-Resistance1", PlayerPrefs.GetString(e3Name + "-Resistance1"));
            PlayerPrefs.SetString("E3-Resistance3", PlayerPrefs.GetString(e3Name + "-Resistance3"));
            PlayerPrefs.SetString("E3-Resistance3", PlayerPrefs.GetString(e3Name + "-Resistance3"));
            PlayerPrefs.SetString("E3-Skill1", PlayerPrefs.GetString(e3Name + "-Skill1"));
            PlayerPrefs.SetString("E3-Skill2", PlayerPrefs.GetString(e3Name + "-Skill2"));
            PlayerPrefs.SetString("E3-Skill3", PlayerPrefs.GetString(e3Name + "-Skill3"));
            PlayerPrefs.SetString("E3-Skill4", PlayerPrefs.GetString(e3Name + "-Skill4"));
            PlayerPrefs.SetString("E3-Skill5", PlayerPrefs.GetString(e3Name + "-Skill5"));
            PlayerPrefs.SetString("E3-Skill6", PlayerPrefs.GetString(e3Name + "-Skill6"));
            GameObject targetHP = GameObject.Find("E3-Hp");
            int PCHP = PlayerPrefs.GetInt("E3-CHP");
            int PMax = PlayerPrefs.GetInt("E3-HP");
            float Percent = 0;
            targetHP.gameObject.transform.localScale = new Vector3(Percent, 1, 1);
            GameObject targetGuard = GameObject.Find("E3-Guard");
            int PCGuard = PlayerPrefs.GetInt("E3-CG");
            int PMaxGuard = PlayerPrefs.GetInt("E3-Guard");
            float PercentGuard = 0;
            targetGuard.gameObject.transform.localScale = new Vector3(PercentGuard, 1, 1);
            GameObject sprite = GameObject.Find("E3");
            LoadSprite.FindSprite(sprite, e3Name);
            BoxCollider2D _boxCollider = GetComponent<BoxCollider2D>();
            Destroy(_boxCollider);
            _boxCollider = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
            // PlayerPrefs.SetInt("E3-Guard", 100);
            PlayerPrefs.SetInt("E3-AttL", 0);
        }
    }
    //used for initial movement
    void SetLoc()
    {
        if (PlayerPrefs.GetString("E3-Name") == "null")
        {

        }
        else
        {
            int time = (int)System.DateTime.Now.Ticks;
            UnityEngine.Random.seed = time;
            // the seed a number in that range
            int Loc = 0;
            PlayerPrefs.SetInt("E-Block-" + PlayerPrefs.GetInt("E3-Loc") + "-Moveable", 1);
            PlayerPrefs.SetInt("E-Block-0-Moveable", 0);
            while (Loc == 0)
            {
                Loc = UnityEngine.Random.Range(1, 16);
                if (PlayerPrefs.GetInt("E-Block-" + Loc.ToString() + "-Moveable") == 0)
                {
                    Loc = 0;
                }
                PlayerPrefs.SetInt("E-Block-" + Loc.ToString() + "-Moveable", 0);
            }
            PlayerPrefs.SetInt("E3-Loc", Loc);
            GameObject Vill = GameObject.Find("E3");
            string e3Name = PlayerPrefs.GetString("E3-Name");
            LoadSprite.FindSprite(Vill, e3Name);
            GameObject VillHp = GameObject.Find("E3-Hp");
            GameObject VillHpBack = GameObject.Find("E3-HpBack");
            GameObject VillGuard = GameObject.Find("E3-Guard");
            GameObject VillStatus0 = GameObject.Find("E3Status0");
            GameObject VillStatus0X = GameObject.Find("E3Status0X");
            Vector3 E3LocQuards = GameObject.Find("E-Block-" + Loc.ToString()).transform.position;
            Vill.transform.position = E3LocQuards + new Vector3(0, +67, -3);
            SpriteRenderer sprite = Vill.GetComponent<SpriteRenderer>();
            int l = Loc + 3;
            l = l / 4;
            sprite.sortingLayerName = "Char" + l;
            VillHp.transform.position = E3LocQuards + new Vector3(-100, -17, 1);
            VillHp = VillHp.transform.GetChild(0).gameObject;
            sprite = VillHp.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "Bar" + l;
            VillHpBack.transform.position = E3LocQuards + new Vector3(0, -17, 1);
            sprite = VillHpBack.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "Back" + l;
            VillStatus0.transform.position = E3LocQuards + new Vector3(-40, 20, 1);
            sprite = VillStatus0.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "Status" + 1;
            VillStatus0X.transform.position = E3LocQuards + new Vector3(-40, 20, 1);
            VillGuard.transform.position = E3LocQuards + new Vector3(-100, -17, 1);
            VillGuard = VillGuard.transform.GetChild(0).gameObject;
            sprite = VillGuard.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "Guard" + l;
        }
    }
    void OnMouseEnter()
    {
        string e3Name = PlayerPrefs.GetString("E3-Name");
        if (e3Name.Substring(e3Name.Length - 8) == "(Stage1)" || e3Name.Substring(e3Name.Length - 8) == "(Stage2)" || e3Name.Substring(e3Name.Length - 8) == "(Stage3)")
        {
            e3Name = e3Name.Remove(e3Name.Length - 9, 9);
        }
        textbox.text = e3Name + " Guard: " + PlayerPrefs.GetInt("E3-CG") + "/" + PlayerPrefs.GetInt("E3-Guard") + " HP: " + PlayerPrefs.GetInt("E3-CHP")
            + "/" + PlayerPrefs.GetInt("E3-HP") + "\n" + "Intent: " + PlayerPrefs.GetString("E3-CAtt") + " " + PlayerPrefs.GetInt("E3-Attack");
        int targ = PlayerPrefs.GetInt("E3-AttL");
        if (targ != 0)
        {
            GameObject IBlock = GameObject.Find("P-Block-" + targ);
            IBlock.GetComponent<SpriteRenderer>().color = Color.red;
        }
        int p = 0;
        if (PlayerPrefs.GetInt("P1-Targeting") == 1)
        {
            p = 1;
        }
        else if (PlayerPrefs.GetInt("P2-Targeting") == 1)
        {
            p = 2;
        }
        else if (PlayerPrefs.GetInt("P3-Targeting") == 1)
        {
            p = 3;
        }
        else if (PlayerPrefs.GetInt("P4-Targeting") == 1)
        {
            p = 4;
        }
        if (p != 0)
        {
            GameObject Hand = GameObject.Find("Hand");
            Hand.transform.position = transform.position + new Vector3(-150, 0, 0);
        }
    }
    public void OnMouseDown()
    {
        PlayerPrefs.SetInt("ENumber", 3);
    }
    public void GiveTurn()
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
        StatusEffect.StatusTickStart("P1");
        StatusEffect.StatusTickStart("P2");
        GameObject PDiss = GameObject.Find("PDiss");
        PDiss.transform.position = new Vector3(-3000, 0, 0);
        GameObject PlayerTurn = GameObject.Find("PlayerTurn");
        PlayerTurn.GetComponent<PlayerTurn>().Begin();
    }
    public void OnMouseExit()
    {
        if (PlayerPrefs.GetInt("Clicked") != 1)
        {
            GameObject IBlock;
            textbox.text = "";
            for (int i = 1; i <= 16; i++)
            {
                IBlock = GameObject.Find("P-Block-" + i);
                IBlock.GetComponent<SpriteRenderer>().color = new Color32(0, 91, 255, 255);
            }
        }
        GameObject Hand = GameObject.Find("Hand");
        Hand.transform.position = new Vector3(-5000, 0, 0);
    }
    public void ChooseAttack()
    {
        //just handles basic attack for now
        int choice = UnityEngine.Random.Range(1, 4);
        PlayerPrefs.SetInt("E3-Choice", choice);
        if (choice == 1)
        {
            PlayerPrefs.SetString("E3-CAtt", "Basic Attack");
            int time = (int)System.DateTime.Now.Ticks;
            UnityEngine.Random.seed = time;
            int p = 0;
            while (PlayerPrefs.GetInt("P" + p + "-CHP") == 0)
            {
                p = UnityEngine.Random.Range(1, 3);
                PlayerPrefs.SetInt("E3-AttP", p);
                PlayerPrefs.SetInt("E3-AttL", PlayerPrefs.GetInt("P" + p + "-Loc"));
            }
        }
        if (choice == 2)
        {
            PlayerPrefs.SetString("E3-CAtt", "Defend");
            PlayerPrefs.SetInt("E3-AttP", 0);
            PlayerPrefs.SetInt("E3-AttL", 0);
        }
        if (choice == 3)
        {
            int skillChoice;
            do
            {
                skillChoice = UnityEngine.Random.Range(1, 7);
            }
            while (PlayerPrefs.GetString("E3-Skill" + skillChoice) == "null");
            PlayerPrefs.SetString("E3-CAtt", PlayerPrefs.GetString("E3-Skill" + skillChoice));
            int time = (int)System.DateTime.Now.Ticks;
            UnityEngine.Random.seed = time;
            int p = 0;
            while (PlayerPrefs.GetInt("P" + p + "-CHP") == 0)
            {
                p = UnityEngine.Random.Range(1, 3);
                PlayerPrefs.SetInt("E3-AttP", p);
                PlayerPrefs.SetInt("E3-AttL", PlayerPrefs.GetInt("P" + p + "-Loc"));
            }
        }
    }
    public void Attack()
    {
        GameObject target = GameObject.Find(PlayerPrefs.GetString("P" + PlayerPrefs.GetInt("E3-AttP") + "-Name"));
        GameObject targetHP = GameObject.Find("P" + PlayerPrefs.GetInt("E3-AttP") + "-Hp");
        GameObject targetG = GameObject.Find("P" + PlayerPrefs.GetInt("E3-AttP") + "-Guard");
        GameObject animg = GameObject.Find("slasher");
        Animator anim = animg.GetComponent<Animator>();
        animg.transform.position = targetHP.transform.position + new Vector3(100, +100, 0); ;
        anim.SetTrigger("Play");
        Invoke("EndAnimation", 1.6f);
        int p = PlayerPrefs.GetInt("E3-AttP");
        int PCHP = PlayerPrefs.GetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-CHP");
        int PCG = PlayerPrefs.GetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-CG");
        int Att = PlayerPrefs.GetInt("E3-Attack");
        string damageType = "Physical";
        if (PlayerPrefs.GetString("P" + p + "-Weakness1") == damageType || PlayerPrefs.GetString("P" + p + "-Weakness2") == damageType)
        {
            Att = (int)Math.Round((float)Att * 1.5, 1);
        }
        if (PlayerPrefs.GetString("P" + p + "-Resistance1") == damageType || PlayerPrefs.GetString("P" + p + "-Resistance3") == damageType || PlayerPrefs.GetString("P" + p + "-Resistance3") == damageType)
        {
            Att = (int)Math.Round((float)Att * 0.75, 1);
        }
        if (PlayerPrefs.GetString("P" + p + "Status0") == "steadfast" || PlayerPrefs.GetString("P" + p + "Status1") == "steadfast" || PlayerPrefs.GetString("P" + p + "Status2") == "steadfast" || PlayerPrefs.GetString("P" + p + "Status3") == "steadfast")
        {
            PCG -= Att;
        }
        else if (PlayerPrefs.GetString("P" + p + "Status0") == "vulnerable" || PlayerPrefs.GetString("P" + p + "Status1") == "vulnerable" || PlayerPrefs.GetString("P" + p + "Status2") == "vulnerable" || PlayerPrefs.GetString("P" + p + "Status3") == "vulnerable")
        {
            PCHP -= Att;
        }
        else
        {
            PCG = PCG - ((Att / 2) + (Att % 2));
            PCHP = PCHP - ((Att / 2));
        }
        if (PCG < 0)
        {
            PCHP = PCHP + PCG;
            PlayerPrefs.SetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-CG", 0);
            PCG = 0;
        }
        else
        {
            PlayerPrefs.SetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-CG", PCG);
        }
        if (PCHP <= 0)
        {
            target.GetComponent<SpriteRenderer>().color = Color.black;
            if (PlayerPrefs.GetInt("P1-CHP") == 0 && PlayerPrefs.GetInt("P2-CHP") == 0)
            {
                Application.LoadLevel("GameOver");
            }
            PCHP = 0;
        }
        PlayerPrefs.SetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-CHP", PCHP);
        PlayerPrefs.SetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-CG", PCG);
        int PMax = PlayerPrefs.GetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-HP");
        float Percent = ((float)PCHP / (float)PMax);
        targetHP.gameObject.transform.localScale = new Vector3(Percent, 1, 1);
        PMax = PlayerPrefs.GetInt("P" + PlayerPrefs.GetInt("E3-AttP") + "-Guard");
        Percent = ((float)PCG / (float)PMax);
        targetG.gameObject.transform.localScale = new Vector3(Percent, 1, 1);
    }
    public void Defend()
    {
        int eCurrentGuard = PlayerPrefs.GetInt("E3-CG");
        int eMaxGuard = PlayerPrefs.GetInt("E3-Guard");
        int eAddedGuard = PlayerPrefs.GetInt("E3-GuardGain");
        eCurrentGuard = eCurrentGuard + eAddedGuard;
        if (eCurrentGuard > eMaxGuard)
        {
            eCurrentGuard = eMaxGuard;
        }
        GameObject GBar = GameObject.Find("E3-Guard");
        float PercentG = ((float)eCurrentGuard / (float)eMaxGuard);
        GBar.gameObject.transform.localScale = new Vector3(PercentG, 1, 1);
        PlayerPrefs.SetInt("E3-CG", eCurrentGuard);
        StatusEffect.InflictStatusEnemy("steadfast", 1, 1);
        Invoke("EndAnimation3", 0.1f);
    }

    public void Skill()
    {
        string skill = String.Concat(PlayerPrefs.GetString("E3-CAtt").Where(c => !Char.IsWhiteSpace(c)));
        SendMessage(skill);
        Invoke("EndAnimation3", 0.1f);
    }
    public void Move()
    {
        //4x4 movement
        int time = (int)System.DateTime.Now.Ticks;
        UnityEngine.Random.seed = time;
        int rando1 = 0;
        int rando2 = 0;
        int rando3 = 0;
        int rando4 = 0;
        List<int> used = new List<int>();
        rando1 = UnityEngine.Random.Range(0, 4);
        used.Add(rando1);
        rando2 = UnityEngine.Random.Range(0, 4);
        while (used.Contains(rando2))
        {
            rando2 = UnityEngine.Random.Range(0, 4);
        }
        used.Add(rando2);
        rando3 = UnityEngine.Random.Range(0, 4);
        while (used.Contains(rando3))
        {
            rando3 = UnityEngine.Random.Range(0, 4);
        }
        used.Add(rando3);
        rando4 = UnityEngine.Random.Range(0, 4);
        while (used.Contains(rando4))
        {
            rando4 = UnityEngine.Random.Range(0, 4);
        }
        int offset = 0;
        int whilebreak = 0;
        int i = 0;
        int left = PlayerPrefs.GetInt("E3-Loc") - 1;
        int up = PlayerPrefs.GetInt("E3-Loc") + 4;
        int down = PlayerPrefs.GetInt("E3-Loc") - 4;
        int right = PlayerPrefs.GetInt("E3-Loc") + 1;
        Vector3 E3LocQuards = new Vector3(0, 0, 0);
        switch (PlayerPrefs.GetInt("E3-Loc"))
        {
            case 1:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + right + "-Moveable") == 1)
                        {
                            MoveTo(right);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + up + "-Moveable") == 1)
                        {
                            MoveTo(up);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 4:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + left + "-Moveable") == 1)
                        {
                            MoveTo(left);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + up + "-Moveable") == 1)
                        {
                            MoveTo(up);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 13:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + right + "-Moveable") == 1)
                        {
                            MoveTo(right);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + down + "-Moveable") == 1)
                        {
                            MoveTo(down);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 16:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + left + "-Moveable") == 1)
                        {
                            MoveTo(left);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + down + "-Moveable") == 1)
                        {
                            MoveTo(down);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 2:
            case 3:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + left + "-Moveable") == 1)
                        {
                            MoveTo(left);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + right + "-Moveable") == 1)
                        {
                            MoveTo(right);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + up + "-Moveable") == 1)
                        {
                            MoveTo(up);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 5:
            case 9:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + right + "-Moveable") == 1)
                        {
                            MoveTo(right);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + up + "-Moveable") == 1)
                        {
                            MoveTo(up);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + down + "-Moveable") == 1)
                        {
                            MoveTo(down);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 8:
            case 12:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + left + "-Moveable") == 1)
                        {
                            MoveTo(left);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + up + "-Moveable") == 1)
                        {
                            MoveTo(up);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + down + "-Moveable") == 1)
                        {
                            MoveTo(down);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 14:
            case 15:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + left + "-Moveable") == 1)
                        {
                            MoveTo(left);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + right + "-Moveable") == 1)
                        {
                            MoveTo(right);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + down + "-Moveable") == 1)
                        {
                            MoveTo(down);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            case 6:
            case 7:
            case 10:
            case 11:
                {
                    while (whilebreak == 0)
                    {
                        if (used[i] == 0 && PlayerPrefs.GetInt("E-Block-" + left + "-Moveable") == 1)
                        {
                            MoveTo(left);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + right + "-Moveable") == 1)
                        {
                            MoveTo(right);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + up + "-Moveable") == 1)
                        {
                            MoveTo(up);
                            whilebreak = 1;
                        }
                        else if (used[i] == 1 && PlayerPrefs.GetInt("E-Block-" + down + "-Moveable") == 1)
                        {
                            MoveTo(down);
                            whilebreak = 1;
                        }
                        i++;
                        if (i > 4)
                        {
                            whilebreak = 1;
                        }
                    }
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
    public void MoveTo(int dest)
    {
        GameObject Vill = GameObject.Find("E3");
        GameObject VillHp = GameObject.Find("E3-Hp");
        GameObject VillHpBack = GameObject.Find("E3-HpBack");
        GameObject VillGuard = GameObject.Find("E3-Guard");
        GameObject Vill1Status0 = GameObject.Find("E3Status0");
        GameObject Vill1Status0X = GameObject.Find("E3Status0X");
        GameObject Vill1Status1 = GameObject.Find("E3Status1");
        GameObject Vill1Status1X = GameObject.Find("E3Status1X");
        GameObject Vill1Status2 = GameObject.Find("E3Status2");
        GameObject Vill1Status2X = GameObject.Find("E3Status2X");
        GameObject Vill1Status3 = GameObject.Find("E3Status3");
        GameObject Vill1Status3X = GameObject.Find("E3Status3X");
        Vector3 E3LocQuards = GameObject.Find("E-Block-" + dest.ToString()).transform.position;
        Vill.transform.position = E3LocQuards + new Vector3(0, +67, -2);
        SpriteRenderer sprite = Vill.GetComponent<SpriteRenderer>();
        int layer = dest + 3;
        layer = layer / 4;
        sprite.sortingLayerName = "Char" + layer;
        VillHp.transform.position = E3LocQuards + new Vector3(-100, -17, 1);
        VillHp = VillHp.transform.GetChild(0).gameObject;
        sprite = VillHp.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Bar" + layer;
        VillHpBack.transform.position = E3LocQuards + new Vector3(0, -17, 1);
        sprite = VillHpBack.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Back" + layer;
        Vill1Status0.transform.position = E3LocQuards + new Vector3(-40, 20, 1);
        sprite = Vill1Status0.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Status" + layer;
        Vill1Status0X.transform.position = E3LocQuards + new Vector3(-40, 20, 1);
        Vill1Status1.transform.position = E3LocQuards + new Vector3(-30, 20, 1);
        sprite = Vill1Status1.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Status" + layer;
        Vill1Status1X.transform.position = E3LocQuards + new Vector3(-30, 20, 1);
        Vill1Status2.transform.position = E3LocQuards + new Vector3(-20, 20, 1);
        sprite = Vill1Status2.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Status" + layer;
        Vill1Status2X.transform.position = E3LocQuards + new Vector3(-20, 20, 1);
        Vill1Status3.transform.position = E3LocQuards + new Vector3(-10, 20, 1);
        sprite = Vill1Status3.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Status" + layer;
        Vill1Status3X.transform.position = E3LocQuards + new Vector3(-10, 20, 1);
        VillGuard.transform.position = E3LocQuards + new Vector3(-100, -17, 1);
        VillGuard = VillGuard.transform.GetChild(0).gameObject;
        sprite = VillGuard.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Guard" + layer;
        PlayerPrefs.SetInt("E-Block-" + PlayerPrefs.GetInt("E3-Loc") + "-Moveable", 1);
        PlayerPrefs.SetInt("E3-Loc", dest);
        PlayerPrefs.SetInt("E-Block-" + dest + "-Moveable", 0);
    }
    public void EndAnimation()
    {
        Vector3 ScreenPos = new Vector3(0, -192, -100);
        GameObject InputDiss = GameObject.Find("InputDiss");
        InputDiss.transform.position = ScreenPos;
        Invoke("EndAnimation2", 0.1f);
    }
    public void EndAnimation2()
    {
        Vector3 ScreenPos = new Vector3(-3000, 0, -100);
        GameObject InputDiss = GameObject.Find("InputDiss");
        InputDiss.transform.position = ScreenPos;
        Invoke("EndAnimation3", 0.1f);
    }
    public void EndAnimation3()
    {
        Vector3 temp = new Vector3(-5000, 0, 0);
        GameObject animg = GameObject.Find("slasher");
        animg.transform.position = temp;
        EndTurn();
    }

    public void EndTurn()
    {
        StatusEffect.StatusTickEnd("E3");
        GameObject E4 = GameObject.Find("E4");
        if (PlayerPrefs.GetString("E3-Name") != "null")
        {
            E4.GetComponent<E4>().TakeTurn4();
            GiveTurn();
        }
        else
        {
            GiveTurn();
        }

    }

    public void TakeTurn()
    {
        GameObject E1 = GameObject.Find("E1");
        E1.GetComponent<E1>().TakeTurn();
    }
    public void TakeTurn3()
    {
        //forgot C lmao
        if (PlayerPrefs.GetInt("E3-CHP") > 0)
        {
            Invoke("Move", 3.8f);
            int choice = PlayerPrefs.GetInt("E3-Choice");
            if (choice == 1) { Invoke("Attack", 3.9f); }
            if (choice == 2) { Invoke("Defend", 3.9f); }
            if (choice == 3) { Invoke("Skill", 3.9f); }
            Invoke("ChooseAttack", 4.0f);
        }
        else
        {
            GiveTurn();
        }
    }
}