using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CreditScene : MonoBehaviour
{
    public void onBack(){
        SceneManager.LoadScene("Main menu");
    }

    public void onCredit(){
        SceneManager.LoadScene("Credit");
    }
}
