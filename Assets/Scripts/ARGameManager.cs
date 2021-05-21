using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ARGameManager : MonoBehaviour
{
    public int numBarrels = 0;
    public int score = 0;
    public GameObject myBall;
    public Transform cameraTransform;
    public GameObject barrelsLeftText;
    public GameObject ScoreText;
    public GameObject finalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ARBarrelScript.whenHit += IncrementScore;
        timer.onEndGame += updateFinalScore;
    }
    private void OnDestroy()
    {
        ARBarrelScript.whenHit -= IncrementScore;
        timer.onEndGame -= updateFinalScore;
    }
    // Update is called once per frame
    void Update()
    {
        shootBall();
        
        TMP_Text currBarrelsLeft = barrelsLeftText.GetComponent<TextMeshProUGUI>();
        currBarrelsLeft.text = numBarrels + " Barrels Left";

        TMP_Text currScore = ScoreText.GetComponent<TextMeshProUGUI>();
        currScore.text = score.ToString();

    }
    public void IncrementBarrel()
    {
        numBarrels++;
    }
    public void IncrementScore()
    {
        score++;
        numBarrels--;
    }
    public void shootBall()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                GameObject ball = Instantiate(myBall, cameraTransform.position + cameraTransform.forward, Quaternion.identity);
                ball.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * 25.0f, ForceMode.Impulse);
            }



            
        }
    }
    public void updateFinalScore()
    {
        TMP_Text finalScore = finalScoreText.GetComponent<TextMeshProUGUI>();
        finalScore.text = "Your final score is " + score.ToString();
    }
}
