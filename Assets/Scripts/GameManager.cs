using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject MechG;
    public GameObject MechS;
    public GameObject MechW;
    public Transform[] Mechspawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMech", 3, 2);
    }


    
    



    void SpawnMech()
    {
        int index = Random.Range(0, Mechspawn.Length);
        //Vector3 spawnPos = Mechspawn[index].position;
        GameObject Mech1= Instantiate(MechG, Mechspawn[0].position, Quaternion.identity);
        GameObject Mech2 = Instantiate(MechS, Mechspawn[1].position, Quaternion.identity);
        GameObject Mech3 = Instantiate(MechW, Mechspawn[2].position, Quaternion.identity);




        //int dirModifier = (index > 2) ? -1 : 1;
        Mech1.GetComponent<MechG>().speed = Random.Range(1.0f, 5.0f);
        Mech2.GetComponent<MechG>().speed = Random.Range(1.0f, 4.0f);
        Mech3.GetComponent<MechG>().speed = Random.Range(1.0f, 8.0f);

    }




}
