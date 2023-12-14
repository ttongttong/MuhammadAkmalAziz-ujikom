using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameSession : MonoBehaviour
{
    GameObject playerGO;
    public Transform playerSpawnPosition;
    public GameObject playerPrefab;

    public float timerValue = 60; 
    public TextMeshProUGUI timerText;
    public bool isDone;

    public GameObject[] animalsPrefab;
    public float secondSpawn = 5f;
    public float minTras;
    public float maxTras;
    public float animalsSpeed = 30;
    Rigidbody animalsRigidBody;
    void Start()
    {
        
        StartCoroutine(AnimalsSpawn());
    }

    IEnumerator AnimalsSpawn()
    {
        while(true)
        {
            var wantrd =Random.Range(minTras, maxTras);
            var position = new Vector3(wantrd, transform.position.y, transform.position.z);
            GameObject animalsGO = Instantiate(animalsPrefab[Random.Range(0,animalsPrefab.Length)], position, Quaternion.identity);
            animalsGO = GetComponent<GameObject>();
            yield return new WaitForSeconds(secondSpawn);
        }
    }
    void Update()
    {
        
        UpdateTimer();
    }
    public void UpdateTimer()
    {
        if(timerValue > 0)
        {
            timerText.text = "TIMER : " + timerValue.ToString();
            timerValue -= Time.deltaTime;
        }
        else
        {
            
        }
    }


}
