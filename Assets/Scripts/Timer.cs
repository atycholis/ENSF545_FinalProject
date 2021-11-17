using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 30.0f;
    public Text displayTime;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        double decimals = System.Math.Round(time, 2);

        if (time > 0)
        {
            time = time - Time.deltaTime;
            displayTime.text = decimals.ToString();

            if(Input.GetKeyDown(KeyCode.Space))
            {
                gameManager.EndScene();
            }
        }

        if(time == 0)
        {
            gameManager.EndScene();
        }
    }
}
