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
        gameManager.GetComponent<GameManager>().SpawnPlayer();//이전 씬에서 선택되었던 캐릭터 소환
    }

    void Update()
    {
        nowTime.text = DateTime.Now.ToString("HH:mm");//현재 시간 표시
    }

}
