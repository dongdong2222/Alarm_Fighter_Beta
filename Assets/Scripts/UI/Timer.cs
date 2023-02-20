using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    Text timeText;
    
    float time;
    void Start()
    {
        time = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
            time -= Time.deltaTime;
        else
        {
            time = 0;
            Managers.Game.GameOver();
        }
        timeText.text = Mathf.Floor(time).ToString();
    }
}
