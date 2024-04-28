using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void onClickCredits()
 {
     SceneManager.LoadScene("creditScene");
 }
 public void onClickplayScene()
 {
     SceneManager.LoadScene("playScene");
 }
}