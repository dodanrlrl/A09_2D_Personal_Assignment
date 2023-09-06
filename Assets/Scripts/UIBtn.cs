using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBtn : MonoBehaviour
{
    public void OnclickSelectPlayer1Btn()
    {
        GameManager.Instance.SelectPlayer1();
    }

    public void OnclickSelectPlayer2Btn() 
    { 
        GameManager.Instance.SelectPlayer2();
    }
        
}
