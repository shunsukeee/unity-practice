using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{

    int playerHp = 100;
    int playerAtk = 50;

    int bossHp = 100;
    int bossAtk = 20;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("魔王が現れた！");
        Turn();
        Turn();
        Debug.Log("魔王のHPが" + bossHp + "になった。魔王をやっつけた");
    }

    void Turn()
    {
        Debug.Log("勇者HP" + playerHp);
        Debug.Log("魔王HP" + bossHp);

        Debug.Log("勇者の攻撃 * 魔王に" + playerAtk + "のダメージを与えた");
        Debug.Log("魔王の攻撃 * 勇者に" + bossAtk + "のダメージを与えた");

        playerHp -= bossAtk;
        bossHp -= playerAtk;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
