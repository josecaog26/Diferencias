using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public GameObject Congratulation;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        
    }

    public void AddPoints(){
        score++;
        if (score == 5) {
            Congratulation.gameObject.SetActive(true);

        }
    }

}
