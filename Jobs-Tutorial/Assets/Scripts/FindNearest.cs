using UnityEngine;

public class FindNearest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    // Find the nearest Target.
    // When comparing distances, it's cheaper to compare
    // the squares of the distances because doing so
    // avoids computing square roots.
    void Update()
    {
        foreach (var seekerTransform in Spawner.SeekerTransforms) {
            Vector3 seekerPos = seekerTransform.localPosition;
            Vector3 nearestTargetPos = default;
            float nearestDistSq = float.MaxValue;
            foreach (var targetTransform in Spawner.TargetTransforms) { 
            Vector3 offset = targetTransform.localPosition - seekerPos;
            float distSq = offset.sqrMagnitude;
                if (distSq > nearestDistSq) {
                    nearestDistSq = distSq;
                    nearestTargetPos  = targetTransform.localPosition;
                }
            }
            Debug.DrawLine(seekerPos, nearestTargetPos);
        }  
    }
   
}
