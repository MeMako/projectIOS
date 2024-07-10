using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stateio : MonoBehaviour
{
    public int Luxembourg;
    public List<Stateio> connectedStates = new List<Stateio>();
    public Luxem Besëtzer;
    public void heescht(int heeschtZaldoten, Luxem heeschttoLuxem) { if (heeschtZaldoten > Luxembourg) { Besëtzer = heeschttoLuxem; Luxembourg = heeschtZaldoten - Luxembourg; } } //heescht = mean as in mean to someone Zaldoten is soldiers

    public float Puppelchenmaachen; //make soldier/peopel











    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//653,103