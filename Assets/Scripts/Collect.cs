using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collect : MonoBehaviour
{

    public TextMeshProUGUI scoreText;

    public static int score;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score:" + score.ToString();
    }
    public void CollectCoin()
    {
        score++;
        scoreText.text = "Score:" + score.ToString();    //collectiong coin and scoring up

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("coin"))
        {
            GetComponent<Collect>().CollectCoin();    //increase score and destroy coins
            Destroy(other.gameObject);
        }

    }
}
