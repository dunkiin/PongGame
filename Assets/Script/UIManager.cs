using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    
    public void UpdateScore(int scoreP1, int scoreP2)
    {
        score.text = scoreP1 + " : " + scoreP2;
    }

}
