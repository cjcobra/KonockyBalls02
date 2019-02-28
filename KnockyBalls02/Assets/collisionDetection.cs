using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionDetection : MonoBehaviour
{

    private float score = 0;
    public Text ScoreText;
    public Text YouWon;

    void OnCollisionEnter(Collision col)
    {
     //   Debug.Log (gameObject.name + " has collided with " + col.gameObject.name);

        if (col.gameObject.name == "Brick")
        {
            score++;
            SetScoreText();

            Debug.Log("Score: " + score);
            Destroy(col.gameObject);
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        YouWon.text = "";

        Debug.Log("Score: " + score);
        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetScoreText()
    {
       // score++;

        ScoreText.text = "Score: " + score.ToString();
        if (score == 12)
        {
            YouWon.text = "YOU WON!";
        }

    }

}
