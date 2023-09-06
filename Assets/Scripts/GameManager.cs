using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    GameObject player = null;

    private static GameManager instance = null;

    private void Awake()
    {
        if(null == instance) //DontDestroyOnload 중복검사
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }



    public void SelectPlayer1()//캐릭터 선택
    {
        SceneManager.LoadScene("SampleScene");
        player = Resources.Load<GameObject>("Prefabs/Player1");
        
    }

    public void SelectPlayer2()
    {
        SceneManager.LoadScene("SampleScene");
        player = Resources.Load<GameObject>("Prefabs/Player2");
    
    }

    public void SpawnPlayer()//선택한 캐릭터 소환
    {
        GameObject playerInstance = Instantiate(player);
    }

}
