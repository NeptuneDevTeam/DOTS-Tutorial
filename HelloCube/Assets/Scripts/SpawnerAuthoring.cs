using Unity.Entities;
using UnityEngine;
public class SpawnerAuthoring : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject CubePrefab;

    class Baker : Baker<SpawnerAuthoring> { 
    public override void Bake(SpawnerAuthoring authoring)
        {
            var entity = GetEntity(authoring, TransformUsageFlags.None);
            var spawner = new Spawner
            {
                CubePrefab = GetEntity(authoring.CubePrefab, TransformUsageFlags.Dynamic)
            };
            AddComponent(entity, spawner);
        }
    
    }

    struct Spawner : IComponentData {

        public Entity CubePrefab;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
