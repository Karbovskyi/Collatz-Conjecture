using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public int inputData;
    void Start()
    {
        IFormula formula = new CollatzConjectureFormula();
        IGraphVerticesGenerator verticesGenerator = new GraphVerticesGenerator(formula);
        List<int> vertices = verticesGenerator.GetVertices(inputData);

        ShowInConsole(vertices);
    }

    private static void ShowInConsole(List<int> vertices)
    {
        foreach (var v in vertices)
        {
            Debug.Log(v);
        }
    }
}