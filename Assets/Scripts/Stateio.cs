using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stateio : MonoBehaviour
{
    //public int Luxembourg;
    //public List<Stateio> connectedStates = new List<Stateio>();
    public Luxem Bes�tzer;//owner
    //public void heescht(int heeschtZaldoten, Luxem heeschttoLuxem) { if (heeschtZaldoten > Luxembourg) { Bes�tzer = heeschttoLuxem; Luxembourg = heeschtZaldoten - Luxembourg; } } //heescht = mean as in mean to someone Zaldoten is soldiers

    //public float Puppelchenmaachen; //make soldier/peopel











    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bes�tzer == null)
        {
            Ray raymond = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(raymond, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Bes�tzer = hit.collider.gameObject.GetComponent<Luxem>();
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
    }
}


//653,103
//2150 soldier two battilions during ww2 with mandatory recruitment