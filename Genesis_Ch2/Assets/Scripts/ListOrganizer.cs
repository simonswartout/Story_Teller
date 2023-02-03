using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOrganizer : MonoBehaviour
{
    [SerializeField] int numbersInList = 10;
    List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numbersInList; i++)
        {
            RandomNumberGenerator();
            PrintList("This is my unsorted list", numbers);
            numbers = ListSorter(numbers);
            PrintList("This is my sorted list", numbers);
        }     
    }

    void PrintList(string message, List<int> list)
    {
        string output = "";
        foreach(int n in list)
        {
            output += n + ", ";
        }

        output = output.Substring(0, output.Length - 2);
        Debug.Log($"{message}: {output}");
    }

    void RandomNumberGenerator()
    {
        int number = Random.Range(0, 100);
        numbers.Add(number);
    }

    List<int> ListSorter(List<int> numbers)
    {
        int n = numbers.Count;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if(numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        return numbers;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
