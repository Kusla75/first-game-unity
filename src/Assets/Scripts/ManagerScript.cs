using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{
    public GameObject completeLevelUI;

    public void Start()
    {
        completeLevelUI.SetActive(false);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        Invoke("Restart", 1.5f);
    }
}
