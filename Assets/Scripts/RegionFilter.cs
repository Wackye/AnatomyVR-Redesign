using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RegionFilter : MonoBehaviour
{
    [SerializeField]
    public bool leftLimb, rightLimb, Chest, Leg, Head;
    // Start is called before the first frame update

    void setState(GameObject[] objs, bool state){
        foreach(var obj in objs)
            obj.SetActive(state);
    }

    List<GameObject> FindInActiveObjectsByLayer(int layer)
    {
        List<GameObject> results;
        results = new List<GameObject>();
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].gameObject.layer == layer)
                {
                    results.Add(objs[i].gameObject);
                }
            }
        }
        return results;
    }
    private void Start() {
        List<GameObject> objects;
        objects = FindInActiveObjectsByLayer(12);
        foreach(GameObject obj in objects)
        {
            obj.SetActive(true);
        }
        Debug.Log("Finish!");
    }
    private void Update() {
        List<GameObject> objects;
        objects = FindInActiveObjectsByLayer(13);
        foreach(GameObject obj in objects)
        {
            obj.SetActive(true);
        }
        Debug.Log("Finish!");

        setState(GameObject.FindGameObjectsWithTag("leftLimb"), leftLimb);
        setState(GameObject.FindGameObjectsWithTag("rightLimb"), rightLimb);   
        setState(GameObject.FindGameObjectsWithTag("Chest"), Chest);  
        setState(GameObject.FindGameObjectsWithTag("leg"), Leg);
        setState(GameObject.FindGameObjectsWithTag("head"), Head);
    }

}
