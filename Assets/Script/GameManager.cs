using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] UIManager uiManager;

    public float courtMinX = -13;
    public float courtMaxX = 13;
    public int scoreP1;
    public int scoreP2;


    void Start()
    {
        ball.Reset();
        ball.Launch();
        uiManager.UpdateScore(scoreP1, scoreP2);
    }

    private void Update()
    {
        if (ball.transform.position.x > courtMaxX)
        {
            scoreP1++;
            uiManager.UpdateScore(scoreP1, scoreP2);
            ball.Reset();
        }
        else if (ball.transform.position.x < courtMinX)
        {   
            scoreP2++;
            uiManager.UpdateScore(scoreP1, scoreP2);
            ball.Reset();
        }

    }




}
