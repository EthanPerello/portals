using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{

    public static int gameOver = 0;
    private Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GetComponent<Text>();

        gameOverText.color = new Color(0, 0, 0, 0);
        gameOverText.text = "You Win!";
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == 1) {
            gameOverText.color = new Color(1, 0, 0, 1);
        }
    }
}
