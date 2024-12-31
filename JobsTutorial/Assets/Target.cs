using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Testing Testing

    public Vector3 Direction;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Direction * Time.deltaTime;
    }
}
