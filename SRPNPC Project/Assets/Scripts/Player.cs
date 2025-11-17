using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public List<GameObject> Enemies;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                if (Enemies[i] != null)
                {
                    Enemies[i].GetComponent<NPC>().TakeDamage(10);
                    break;
                }
            }

            //i = 0;
            //if(enemies[i] == null)
                //i++;
            //enemies[i].takedamage()
        }
    }
}
