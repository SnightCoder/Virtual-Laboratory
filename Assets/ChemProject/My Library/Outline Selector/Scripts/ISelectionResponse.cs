using UnityEngine;

internal interface ISelectionResponse{
    void OnDeselect(Transform selection);
    void OnSelect(Transform selection);
}