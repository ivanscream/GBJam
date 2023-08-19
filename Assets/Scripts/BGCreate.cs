using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCreate : MonoBehaviour
{
    public GameObject nowBg, bgInstantiate;
    public GameObject nowForest, forestInstantiate;
    public GameObject nowRoad, roadInstantiate;
    
    private GameObject newBg, newForest, newRoad;

    public float newBgPos, oldBgPos;
    public float newForestPos, oldForestPos;
    public float newRoadPos, oldRoadPos;

    private void Update() {
        
        if(nowBg.transform.position.x <= 0 && newBg == null)
                CreateNewBg();
        
        else if(newBg != null && newBg.transform.position.x <= 0)
                CreateNewBg();
        
        if(nowForest.transform.position.x <= 0 && newForest == null)
            CreateNewForest();
        
        else if(newForest != null && newForest.transform.position.x <= 0)
            CreateNewForest();
        
        if(nowRoad.transform.position.x <= 0 && newRoad == null)
            CreateNewRoad();
        
        else if(newRoad != null && newRoad.transform.position.x <= 0)
            CreateNewRoad();
        
    }

    void CreateNewRoad()
    {
        if(nowRoad.transform.position.x < oldRoadPos)
        {
            Destroy(nowRoad);
            nowRoad = newRoad;
        }
        

        newRoad = Instantiate(roadInstantiate, new Vector2(newRoadPos, 0), Quaternion.identity)
            as GameObject;
    }

    void CreateNewForest()
    {
        if(nowForest.transform.position.x < oldForestPos)
        {
            Destroy(nowForest);
            nowForest = newForest;
        }
        

        newForest = Instantiate(forestInstantiate, new Vector2(newForestPos, 0), Quaternion.identity)
            as GameObject;
    }

    void CreateNewBg() {
        
        if(nowBg.transform.position.x < oldBgPos)
        {
            Destroy(nowBg);
            nowBg = newBg;
        }
        

        newBg = Instantiate(bgInstantiate, new Vector2(newBgPos, 0), Quaternion.identity)
            as GameObject;
    }
}
