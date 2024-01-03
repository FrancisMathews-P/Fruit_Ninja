using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject melon;
    public Transform ReleasePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBox()); 
    }
    IEnumerator SpawnBox()
    {
        while(true)
        {
            Instantiate(melon, ReleasePoint.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
    
        
