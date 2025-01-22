using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1.0f;

    int minX;
    int maxX;

    int scoreP1;
    int scoreP2;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Reset()
    {
 
    }

    void Launch(Vector3 direction, float speed)
    {
        
    }

    void GetRandomBallDirection()
    {
        
    }


}
