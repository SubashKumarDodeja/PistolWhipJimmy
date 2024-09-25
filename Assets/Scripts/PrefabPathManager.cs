using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPathManager : MonoBehaviour
{
    public Patch patchPrefab;
    public float offset=-40f;


    public Patch[] generatedPrefabs = new Patch[3];
    int nextIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        //i++ 
        // i = i+1
        // Generate out path 3 times
       for(int i = 0; i < 3; i++)
       {
            //i =0 //z=0
            //i =1 //z=-40
            //i =2 //z=-80
            generatedPrefabs[i]=Instantiate(patchPrefab, new Vector3(0, 0, i * offset), Quaternion.identity);
            generatedPrefabs[i].pathManager = this;
            generatedPrefabs[i].index = i;

       }
       
    }
    public void AssignNewPositon(int index)
    {
        float newZPositon = (generatedPrefabs.Length + nextIndex) * offset;
        generatedPrefabs[index].transform.position = new Vector3(0, 0, newZPositon);
        nextIndex++;
    }

}
