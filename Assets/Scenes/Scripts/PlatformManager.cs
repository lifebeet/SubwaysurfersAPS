    using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField]
    private Transform platformsPivot;
    [SerializeField]
    private InstantiatePoolObjects[]platformPrefabs;
    [SerializeField]
    private  InstantiatePoolObjects[] securePlatformPrefabs;
    [SerializeField]
     private int initialPlatforms = 5;
     [SerializeField]
     private float speed = 5f;
     private bool isRunning = true;
     private GameObject lastPlatform;
     private int platformsInstantiated = 0;
     private void Start()
    {
        lastPlatform = null;
        platformsInstantiated = 0;
        InitializePlatforms();
        InstantiatePlatfotm(initialPlatforms);
        transform.position = platformsPivot.position;
        isRunning = true;
        
    }
    private void  InitializePlatforms()
    {
        foreach (var platforms in platformPrefabs)
        {
            platforms.DeactivateAllObjects();
        }
    }
    public void InstantiatePlatfotm(int number)
    {
        for (int i = 0; i < number; i++)
        {InstantiatePoolObjects instantiatePool;
                   if (platformsInstantiated < 2)
            {
                instantiatePool = securePlatformPrefabs[Random.Range(0, securePlatformPrefabs.Length)];
            }else
            {
                instantiatePool = platformPrefabs[Random.Range(0, platformPrefabs.Length)];
            }
            platformsInstantiated++;
            Vector3 spawnPosition = Vector3.zero;
            if (lastPlatform != null)
            {
                
                spawnPosition  = lastPlatform.transform.localPosition + lastPlatform.GetComponent<Platform>().ColliderSize * Vector3.forward;    
            }
            instantiatePool.InstantiateObject(spawnPosition);
             GameObject newPlatform = instantiatePool.GetCurrentObject();
                newPlatform.transform.SetParent(transform);
                newPlatform.transform.localPosition = spawnPosition + newPlatform.GetComponent<Collider>().bounds.size.z * Vector3.forward * 0.5f;
                lastPlatform = newPlatform;
            }
    }
    private void Update()
    {
        if (isRunning)  
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
    public void StopPlatforms()
    {
        isRunning= false;

    }
    
}
