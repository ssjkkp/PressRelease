using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusScript : MonoBehaviour
{
    public static bool press;
    public TextMeshProUGUI statusText;
    public TextMeshProUGUI scoreText;

    private void Update()
    {

        scoreText.SetText(ButtonScript.score.ToString());
    }
    private void Start()
    {
        press = true;

        StartCoroutine("PressReleaseCoroutine");
    }

    IEnumerator PressReleaseCoroutine()
    {
    for (var i = 0; i < 20; i++)
    {
        press = !press;
        if (press)
        {
            statusText.SetText("on");
        }
        else
        {
            statusText.SetText("off");
        }
        yield return new WaitForSeconds(3);
        }
    }
}
