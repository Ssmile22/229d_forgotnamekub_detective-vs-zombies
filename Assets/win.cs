using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter2D(Collider2D other)
     {
    if (other.gameObject.CompareTag("P1"))
    {
    SceneManager.LoadScene(sceneName);
    }
    }
}
