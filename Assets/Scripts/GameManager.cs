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
        if(null == instance) //DontDestroyOnload �ߺ��˻�
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



    public void SelectPlayer1()//ĳ���� ����
    {
        SceneManager.LoadScene("SampleScene");
        player = Resources.Load<GameObject>("Prefabs/Player1");
        
    }

    public void SelectPlayer2()
    {
        SceneManager.LoadScene("SampleScene");
        player = Resources.Load<GameObject>("Prefabs/Player2");
    
    }

    public void SpawnPlayer()//������ ĳ���� ��ȯ
    {
        GameObject playerInstance = Instantiate(player);
    }

}
