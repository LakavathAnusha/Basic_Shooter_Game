using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyGameObject : MonoBehaviour
{
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            score = score + 1;
            Debug.Log("score" + score);
        }
        if(score==5)
        {
            Debug.Log("you won the Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            score = 0;
        }

    }
}
