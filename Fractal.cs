using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour
{
    public int size = (int) Mathf.Pow(3,1);
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public GameObject cubePrefab;
    void Start()
    {
        GenerateFractal(size, x, y, z);
    }

    public void GenerateFractal(int size, int x, int y, int z)
    {
        if(size > 1f)
        {
            size /= 3;

            GenerateFractal(size, x, y, z);
            GenerateFractal(size, x+size, y, z);
            GenerateFractal(size, x+2*size, y, z);
            GenerateFractal(size, x+2*size, y+size, z);
            GenerateFractal(size, x, y+size, z);
            GenerateFractal(size, x, y+2*size, z);
            GenerateFractal(size, x+size, y+2*size, z);
            GenerateFractal(size, x+2*size, y+2*size, z);
            
            GenerateFractal(size, x, y, z+size);
            GenerateFractal(size, x+2*size, y, z+size);
            GenerateFractal(size, x, y+2*size, z+size);
            GenerateFractal(size, x+2*size, y+2*size, z+size);

            GenerateFractal(size, x, y, z+2*size);
            GenerateFractal(size, x+size, y, z+2*size);
            GenerateFractal(size, x+2*size, y, z+2*size);
            GenerateFractal(size, x+2*size, y+size, z+2*size);
            GenerateFractal(size, x, y+size, z+2*size);
            GenerateFractal(size, x, y+2*size, z+2*size);
            GenerateFractal(size, x+size, y+2*size, z+2*size);
            GenerateFractal(size, x+2*size, y+2*size, z+2*size);
            
        } else
        {
            GameObject p = Instantiate(cubePrefab, new Vector3(x, y, z), Quaternion.identity, transform.parent);
            p.transform.parent = transform;
        }

    }
}