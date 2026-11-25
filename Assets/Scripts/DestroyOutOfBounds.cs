using UnityEngine;

public class DestroyOutOfBounds :  MonoBehaviour
{
    private float _topBound = 40f;
    private float _bottomBound = -20f;
    
    
    void Update()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < _bottomBound)
        {
            Destroy(gameObject);
        }    }
}