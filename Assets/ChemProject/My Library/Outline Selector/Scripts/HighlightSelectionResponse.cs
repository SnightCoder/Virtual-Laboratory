using UnityEngine;
[RequireComponent (typeof(SelectionManager))]
internal class HighlightSelectionResponse:MonoBehaviour,ISelectionResponse
{
    [SerializeField] public Material highlightMaterial;
    [SerializeField] public Material defaultMaterial;

    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
            selectionRenderer.material = this.defaultMaterial;
    }
    public void OnSelect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
            selectionRenderer.material = this.highlightMaterial;
    }

}
