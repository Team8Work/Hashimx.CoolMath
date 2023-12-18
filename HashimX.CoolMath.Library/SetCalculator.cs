
using System.Security.Cryptography.X509Certificates;
using HashimX.CoolMath.library.UserDefinedTypes;
using System.Collections.Generic;
using System.Linq;

namespace HashimX.CoolMath.library;
public class SetCalculator
{
    public Set Union(Set S1, Set S2)
    {
        Set result = new Set();
        result.Name = "UnionResult Set ";
        result = S1;
        int elemCount = S2.Elements.Count;
        for (int i = 0; i < elemCount; i++)
        {
            int x = S2.Elements[i];
            bool boolResult = result.Elements.Contains(x);
            if (boolResult == false)
            {
                result.Insert(x);
            }
        }
        return result;
    }
    public Set Intersection(Set S1, Set S2)
    {
        Set result2 = new Set();
        result2.Name = "Intersection Result Set";
        int elemCount = S1.Elements.Count;
        for (int i = 0; i < elemCount; i++)
        {
            int a = S1.Elements[i];
            bool boolResult = S2.Elements.Contains(a);
            if (boolResult == true)
            {
                result2.Insert(a);
            }
        }
        // int elemCount2 = S2.Elements.Count;
        // for (int j = 0; j < elemCount2; j++)
        // {
        //     int b = S2.Elements[j];
        //     bool boolResult2 = S1.Elements.Contains(b);
        //     if (boolResult2 == true)
        //     {
        //         bool boolResult3 = result2.Elements.Contains(b);
        //         if (boolResult3 == false)
        //         {
        //             result2.Insert(b);
        //         }
        //     }
        // }
        return result2;
    }
    public Set Difference(Set S1, Set S2)
    {
        Set result3 = new Set();
        result3.Name = "Difference Result Set";
        result3 = S1;
        int elemCount = S2.Elements.Count;
        for (int i = 0; i < elemCount; i++)
        {
            int x = S2.Elements[i];
            bool boolResult = result3.Elements.Contains(x);
            if (boolResult == true)
            {
                result3.Remove(x);
            }
        }
        return result3;
    }
    public bool IsSubSets(Set S1, Set S2)
    {
        bool result = true;
        // S1 is subet of S2
        // it means. All elements of S1 must be inside S2
        int S1_Count = S1.Elements.Count();
        for(int i=0; i < S1_Count; i++)
        {
            int elem = S1.Elements[i];
            bool isContained = S2.Elements.Contains(elem);
            if(isContained == false){
                result = false;
            }
        }
        return result;
    }
}