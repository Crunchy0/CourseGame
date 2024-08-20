using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] templates;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnMonsters()
    {
		while(true)
		{
			yield return new WaitForSeconds(Random.Range(1, 5));

			randomIndex = Random.Range(0, templates.Length);
			randomSide = Random.Range(0, 2);

			spawnedMonster = Instantiate(templates[randomIndex]);

			spawnedMonster.transform.position = randomSide == 1 ? rightPos.position : leftPos.position;
			spawnedMonster.GetComponent<Monster>().speed = randomSide == 1 ? -7f : 7f;
			spawnedMonster.GetComponent<SpriteRenderer>().flipX = randomSide == 1 ? true : false;
		}
    }
}
