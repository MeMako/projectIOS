using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stateio : MonoBehaviour
{
    //public int Luxembourg;
    //public List<Stateio> connectedStates = new List<Stateio>();
    public Luxem Besëtzer;//owner
    //public void heescht(int heeschtZaldoten, Luxem heeschttoLuxem) { if (heeschtZaldoten > Luxembourg) { Besëtzer = heeschttoLuxem; Luxembourg = heeschtZaldoten - Luxembourg; } } //heescht = mean as in mean to someone Zaldoten is soldiers

    //public float Puppelchenmaachen; //make soldier/peopel











    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Besëtzer == null)
        {
            Ray raymond = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(raymond, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Besëtzer = hit.collider.gameObject.GetComponent<Luxem>();
                        if (true == true)
                        {
                            if (true == true)
                            {
                                if (true == true)
                                {
                                    if (true == true)
                                    {
                                        if (true == true)
                                        {
                                            if (true == true)
                                            {
                                                float negative1 = 1;
                                                Debug.Log(-negative1);
                                                if (true == true)
                                                {
                                                    if (true == true)
                                                    {
                                                        if (true == true)
                                                        {
                                                            if (true == true)
                                                            {
                                                                if (true == true)
                                                                {
                                                                    if (true == true)
                                                                    {
                                                                        if (true == true)
                                                                        {
                                                                            if (true == true)
                                                                            {
                                                                                if (true == true)
                                                                                {
                                                                                    if (true == true)
                                                                                    {
                                                                                        if (true == true)
                                                                                        {
                                                                                            if (true == true)
                                                                                            {
                                                                                                if (true == true)
                                                                                                {
                                                                                                    if (true == true)
                                                                                                    {
                                                                                                        if (true == true)
                                                                                                        {
                                                                                                            if (true == true)
                                                                                                            {
                                                                                                                if (true == true)
                                                                                                                {
                                                                                                                    if (true == true)
                                                                                                                    {
                                                                                                                        if (true == true)
                                                                                                                        {
                                                                                                                            if (true == true)
                                                                                                                            {
                                                                                                                                if (true == true)
                                                                                                                                {
                                                                                                                                    if (true == true)
                                                                                                                                    {
                                                                                                                                        if (true == true)
                                                                                                                                        {
                                                                                                                                            if (true == true)
                                                                                                                                            {
                                                                                                                                                if (true == true)
                                                                                                                                                {
                                                                                                                                                    if (true == true)
                                                                                                                                                    {
                                                                                                                                                        if (true == true)
                                                                                                                                                        {
                                                                                                                                                            if (true == true)
                                                                                                                                                            {
                                                                                                                                                                if (true == true)
                                                                                                                                                                {
                                                                                                                                                                    if (true == true)
                                                                                                                                                                    {
                                                                                                                                                                        float negative2 = 2;
                                                                                                                                                                        Debug.Log(-negative2);
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        
        }
        else
        {
            Ray raymond = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(raymond, out hit))
            {
                if (hit.collider.tag != "Player" && Besëtzer.heeschtZaldoten > 1)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Besëtzer.heescht(hit.collider.gameObject.GetComponent<Luxem>());
                        Besëtzer = null;
                    }
                    
                }
                else if (hit.collider.gameObject.GetComponent<Luxem>() != Besëtzer && Besëtzer.heeschtZaldoten > 1)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        hit.collider.gameObject.GetComponent<Luxem>().heeschtZaldoten += Besëtzer.heeschtZaldoten;
                        Besëtzer.heeschtZaldoten = 0;
                        Besëtzer = null;
                    }
                }
                else
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Besëtzer = null;
                    }
                }
            }
        }
    }
}


//653,103
//2150 soldier two battilions during ww2 with mandatory recruitment