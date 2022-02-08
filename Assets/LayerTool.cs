using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTool : MonoBehaviour
{
    public class Layer {
        GameObject item;
        int depth;

        public Layer(GameObject i, int d)
        {
            this.item = i;
            this.depth = d;
        }
    }
    
    List<Layer> _layers;
    public GameObject layers;
    public bool isAcitved;

    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        isAcitved = false;
        _layers = new List<Layer>();
        for(int i = 0; i < layers.transform.childCount; i++)
        {
            Layer tmp = new Layer(layers.transform.GetChild(i).gameObject, i); 
            _layers.Add(tmp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
