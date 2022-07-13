using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnController : MonoBehaviour
{
    public GameObject pipePrefab;
    public float maxpositionY;
    public float minpositionY;
    public float pipeBackSpeed;
    float randomHeight;
    float pipeGap;
    Vector3 pipeVec;


    void Start()
    {
        PipeSpawn();
    }

    public void PipeSpawn()
    {

        pipeGap += 5;
        randomHeight = Random.Range(minpositionY, maxpositionY);
        pipeVec = new Vector3(transform.position.x + pipeGap, randomHeight, transform.position.z);



        GameObject formedPipe = Instantiate(pipePrefab, pipeVec, Quaternion.identity);
        formedPipe.transform.parent = gameObject.transform;


    }

    private void Update()
    {
        transform.Translate(Vector2.left * pipeBackSpeed * Time.deltaTime);

    }
}
