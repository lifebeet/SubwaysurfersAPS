using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField]
    private Transform platformsPivot;
    [SerializeField]
    private GameObject[]platformPrefabs;
    [SerializeField]
     private int initialPlatforms = 5;
     [SerializeField]
     private float speed = 5f;
     private bool isRunning = true;
     private GameObject lastPlatform;
     private void Start()
    {
        InstantiatePlatfotm(initialPlatforms);
        transfotm.position = platformsPivot.position;
    }
    public void InstantiatePlatfotm(int number)
    {
        GameObject platformPrefab =platformPrefab
    }
}
