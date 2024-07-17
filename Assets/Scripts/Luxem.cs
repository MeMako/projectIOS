using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Luxem : MonoBehaviour
{
    public MeshRenderer Faarf;//Color
    public string genannt;//Name
    public int heeschtZaldoten;//Mean Soldier
    bool Auerufänken = false;

    private TMP_Text count;

    private void Start()
    {
        Faarf = GetComponent<MeshRenderer>();
        count = GetComponentInChildren<TMP_Text>();
    }

    private void Update()
    {
        if (!Auerufänken)
        {
            Auerufänken = true;
            Invoke("regen", 16f);
        }
        count.text = heeschtZaldoten.ToString();
    }

    public void ReplaceMaterial(Material mat)
    {
        Faarf.material = mat;

    }

    // Update is called once per frame
    public void heescht(Luxem Ziel)//target
    {
        if (Ziel.heeschtZaldoten < heeschtZaldoten)//place attack if less
        {
            heeschtZaldoten -= Ziel.heeschtZaldoten;//yep
            Ziel.heeschtZaldoten = heeschtZaldoten;//yep
            heeschtZaldoten = 1;//yep
            Ziel.ReplaceMaterial(Faarf.material);//yep
            Ziel.gameObject.tag = "Player";
        }
    }
    private void regen ()
    {
        heeschtZaldoten++;
        Auerufänken = false;
    }
}
