using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScreeen : MonoBehaviour
{
    public GameObject Endscreen;
    public static bool gameIsCompleted = false;

    private void OnTriggerEnter(Collider other)
    { 

        if (other.gameObject.tag == "woshishuaige")
        {
            Debug.Log("This is triggred");
            Endscreen.gameObject.SetActive(true);
            gameIsCompleted = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if ((SceneManager.GetActiveScene().buildIndex + 1) > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", (SceneManager.GetActiveScene().buildIndex + 1));
            }

        }
    }

}
