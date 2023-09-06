using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public Text nowTime;
    GameObject gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameManager.GetComponent<GameManager>().SpawnPlayer();//���� ������ ���õǾ��� ĳ���� ��ȯ
    }

    void Update()
    {
        nowTime.text = DateTime.Now.ToString("HH:mm");//���� �ð� ǥ��
    }

}
