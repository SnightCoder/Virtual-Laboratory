using UnityEngine;

internal class RayCastBasedTagSelector : MonoBehaviour, ISelector
{
    [SerializeField] public string[] selectableTag;
    public Transform _selection;
    public LayerMask layer;
    public Transform GetSelection()
    {
        return this._selection;
    }
    public void Check(Ray ray)
    {
        this._selection = null;
        if (Physics.Raycast(ray, out var hit,layer))
        {
            var selection = hit.transform;
            foreach (var item in selectableTag)
            {
                if (selection.CompareTag(item))
                {
                    this._selection = selection;
                }
            }

        }
    }
}
