using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    public string firstName = "Johannes";
    public string lastName = "Knudsen";


    public int a = 5;
    public int b = 10;


    void Start()
    {

        // Debug.Log(LargestNumber(a, b));

        InsertAndFindPartyMember(firstName + " " + lastName, 4);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private int LargestNumber(int a, int b)
    {
        switch (a >= b)
        {
            case true:
                return a;
            case false:
                return b;
        }
    }

    public void InsertAndFindPartyMember(string name, int index)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        QuestPartyMembers.Add("Craven the Necromancer");
        QuestPartyMembers.Insert(1, "Tanis the Thief");
        // Insert name at index
        QuestPartyMembers.Insert(index, name);
        // QuestPartyMembers.RemoveAt(0);

        int listLength = QuestPartyMembers.Count;

        Debug.LogFormat("Party Members: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == name)
            {
                Debug.Log("Glad you're here " + name + "!");
            }
        }
    }
}
