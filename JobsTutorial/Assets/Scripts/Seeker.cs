using UnityEngine;

public class Seeker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 Direction;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Direction * Time.deltaTime;  
    }
}
