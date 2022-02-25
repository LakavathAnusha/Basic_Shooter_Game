using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyGameObject : MonoBehaviour
{
    

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
        ScoreManager score;
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            score.ScoreCalculator(10);
        }
    

    }
}
