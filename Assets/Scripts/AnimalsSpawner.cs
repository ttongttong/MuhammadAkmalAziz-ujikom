using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsSpawner : MonoBehaviour
{
    public GameObject[] animalsPrefab;
    public float secondSpawn = 5f;
    public float minTras;
    public float maxTras;
    void Start()
    {
        StartCoroutine(AnimalsSpawn());
    }

    IEnumerator AnimalsSpawn()
    {
        while(true)
        {
            var wantrd =Random.Range(minTras, maxTras);
            var position = new Vector2(wantrd, transform.position.y);
            GameObject animalsGO = Instantiate(animalsPrefab[Random.Range(0,animalsPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
