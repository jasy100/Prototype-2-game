using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public Game_Manager manager;
    //public GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        /*if (manager == null)
        {
            Debug.LogError("Manager reference not set! Please assign it in the Inspector.");
        }*/
        manager = GameObject.Find("GameManager").GetComponent<Game_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GameManager")
        {
            Debug.Log("GameManager found!");
            //gameObject.SetActive(true);
            //return;
        }
        //if (other.gameObject.name == "GameManager")
        else
        {
            //gameObject.SetActive(false);
            //other.gameObject.SetActive(t);
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("Collided with pizza");
            manager.Points += 1;
        }
        
    }
}
