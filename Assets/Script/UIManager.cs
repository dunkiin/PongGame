using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    
    public void UpdateScores(int scoreP1, int scoreP2)
    {
        if (transform.position.x > maxX)
        {
            scoreP1++;
            Reset();
        }
        else if (transform.position.x < minX)
        {   
            scoreP2++;
            Reset();
        }

        score.text = scoreP1 + " : " + scoreP2;
    }


    // private void Update()
    // {
    //     if (transform.position.x > maxX)
    //     {
    //         scoreP1++;
    //         Reset();
    //     }
    //     else if (transform.position.x < minX)
    //     {   
    //         scoreP2++;
    //         Reset();
    //     }
    // }
}
