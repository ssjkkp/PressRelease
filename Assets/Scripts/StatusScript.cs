using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusScript : MonoBehaviour
{
    public static bool press;
    public TextMeshProUGUI StatusText;
    public TextMeshProUGUI ScoreText;
    public Image ScoreImage;
    private int ScoreImageTop;

    private void Start()
    {
        press = true;
        ScoreImageTop = 0;
        StartCoroutine("PressReleaseCoroutine");
    }

    private void Update()
    {

        ScoreText.SetText(ButtonScript.score.ToString());
        if (ScoreImageTop + ButtonScript.score < 1280)
        {
            ScoreImage.rectTransform.sizeDelta = new Vector2(0, ScoreImageTop + ButtonScript.score);
        }
        else
        {
            Debug.Log("Scoreimage<0: "+ ScoreImageTop);
        }
    }


    IEnumerator PressReleaseCoroutine()
    {
    for (var i = 0; i < 200; i++)
    {

        press = !press;
        if (press)
        {
            StatusText.SetText("PRESS");
        }
        else
        {
            StatusText.SetText("RELEASE");
        }
            System.Random rnd = new System.Random();
            int waitTime = rnd.Next(0, 3);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
