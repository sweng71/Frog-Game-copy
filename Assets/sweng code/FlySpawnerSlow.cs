using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawnerSlow : MonoBehaviour
{

    [SerializeField]
    private GameObject[] flyReference;
    private GameObject spawnedFly;
    [SerializeField]
    private Transform leftPos, rightPos;
    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFlies());
    }


    // Update is called once per frame
    IEnumerator SpawnFlies() // Call over and over gain ever random seconds
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(5, 10));

            randomIndex = Random.Range(0, flyReference.Length);
            randomSide = Random.Range(0,2);

            spawnedFly = Instantiate(flyReference[randomIndex]);

            if (randomSide == 0) //left side
            {
                spawnedFly.transform.position  = leftPos.position;
                spawnedFly.GetComponent<Fly>().speed = Random.Range(4,10);
            }
            else //right side
            {
                spawnedFly.transform.position  = rightPos.position;
                spawnedFly.GetComponent<Fly>().speed = -Random.Range(4,10);
                // spawnedFly.transform.localScale = new Vector3(-1f, 1f, 1f)  - Used for correct orientation but do not need for MVP   
            }
        }
    }
}