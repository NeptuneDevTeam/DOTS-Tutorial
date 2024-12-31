using UnityEngine;

public class Target : MonoBehaviour
{
    public Vector3 Direction;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Direction * Time.deltaTime; 
    }
}
