using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdTriggerController : MonoBehaviour
{
    [SerializeField] PipeSpawnController pipeSpawnController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pipe") || other.gameObject.CompareTag("Base"))
        {
            SceneManager.LoadScene(0);
        }
        if (other.gameObject.CompareTag("Point"))
        {
            pipeSpawnController.PipeSpawn();
        }

    }
}
