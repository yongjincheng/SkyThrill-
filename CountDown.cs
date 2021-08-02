using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float currentTime = 0f;
    public float startingTime = 20f;
    public float restartDelay = 2f;

    [SerializeField] Text countdownText;

    // Update is called once per frame
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        if (PauseButton.gameIsPaused || EndScreeen.gameIsCompleted)
        {

        }
        else if (TeleportBackHelper.dead)
        {
                currentTime = startingTime;
                TeleportBackHelper.dead = false;
        }
        else
        {
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                Invoke("Restart", restartDelay);
            }
            else if (currentTime <= 30)
            {
                countdownText.color = Color.red;
                countdownText.text = currentTime.ToString("F1");
            }
            else
            {
                countdownText.text = currentTime.ToString("0");

            }
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
}
