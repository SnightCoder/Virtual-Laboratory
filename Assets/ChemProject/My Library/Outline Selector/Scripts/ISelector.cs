using UnityEngine;

internal interface ISelector
{
    void Check(Ray ray);
    Transform GetSelection();
}
