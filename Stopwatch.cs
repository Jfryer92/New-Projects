using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    //public Text currentTimertext;
    public bool playing;
    public float Timer;
    public TMP_Text currentTimertext;

    void Start()
    {
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {

            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60F);
            int seconds = Mathf.FloorToInt(Timer % 60F);
            currentTimertext.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }

}