using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Restart(){
    SceneManager.LoadScene("SampleScene");
   }

   public void Menu(){
    SceneManager.LoadScene("Main menu");
   }
}
