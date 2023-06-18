using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    int healt = 3;
    // Start is called before the first frame update
    public void IncreaseScore()
    {
        score = score + 1;
        Debug.Log("score " + score);
    }
    public void IncreaseHealt()
    {
        if (healt == 0)
        {
            Debug.Log("game over");
        }
        else
        {
            Debug.Log("healt " + healt);
            healt -= 1;
        }
            
    }
}
