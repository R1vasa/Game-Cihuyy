using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text="Score: " + Mathf.Round(scoreCount);
    }
}
