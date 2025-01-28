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

    }

    private void Update()
    {
        if (transform.position.x > courtMaxX)
        {
            scoreP1++;
            ball.Reset();
        }
        else if (transform.position.x < courtMinX)
        {   
            scoreP2++;
            ball.Reset();
        }
        
        uiManager.UpdateScore(scoreP1, scoreP2);
    }




}
