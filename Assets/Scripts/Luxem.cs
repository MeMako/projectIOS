using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luxem : MonoBehaviour
{
    public MeshRenderer Faarf;//Color
    public string genannt;//Name
    public int heeschtZaldoten;//Mean Soldier

    // Start is called before the first frame update
    void ReplaceMaterial(Material mat)
    {
        Faarf.material = mat;

    }

    // Update is called once per frame
    void heescht(Luxem Ziel)//target
    {
        if (Ziel.heeschtZaldoten < heeschtZaldoten)//place attack if less
        {
            heeschtZaldoten -= Ziel.heeschtZaldoten;//yep
            Ziel.heeschtZaldoten = heeschtZaldoten;//yep
            heeschtZaldoten = 0;//yep
            Ziel.ReplaceMaterial(Faarf.material);//yep
        }
    }
}
