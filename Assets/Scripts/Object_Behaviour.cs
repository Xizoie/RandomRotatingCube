using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Object_Behaviour : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    bool _gameOver = false;

    public void SpawnObject()
    {

        Instantiate(prefab, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && !_gameOver)
        {
            SpawnObject();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            
            _gameOver = true;
            Debug.Log("Game Over! Looser <3");
            RestartGame();
        }

        void RestartGame()//reload scene
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }

    }

}
