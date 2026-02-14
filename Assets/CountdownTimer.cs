using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] float remainingTime;
    bool hasQuit = false;
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            timertext.color = Color.red;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            hasQuit = true; // Estää useat kutsut

            // Lopeta peli (skripti HW1:sta)
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
