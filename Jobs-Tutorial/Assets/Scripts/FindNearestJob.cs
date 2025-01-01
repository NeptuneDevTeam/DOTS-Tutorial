using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

// We'll use Unity.Mathematics.float3 instead of Vector3,
// and we'll use Unity.Mathematics.math.distancesq instead of Vector3.sqrMagnitude.
using Unity.Mathematics;

// Include the BurstCompile attribute to Burst compile the job.
[BurstCompile]
public struct FindNearestJob : IJob
{
    // All of the data which a job will access should 
    // be included in its fields. In this case, the job needs
    // three arrays of float3.

    // Array and collection fields that are only read in
    // the job should be marked with the ReadOnly attribute.
    // Although not strictly necessary in this case, marking data  
    // as ReadOnly may allow the job scheduler to safely run 
    // more jobs concurrently with each other.
    [ReadOnly] public NativeArray<float3> TargetPositions;
    [ReadOnly] public NativeArray<float3> SeekerPositions;

    // For SeekerPositions[i], we will assign the nearest 
    // target position to NearestTargetPositions[i].

    public NativeArray<float3> NearestTargetPositions;

    // 'Execute' is the only method of the IJob interface.
    // When a worker thread executes the job, it calls this method.
    public void Execute()
    {
        throw new System.NotImplementedException();




    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
