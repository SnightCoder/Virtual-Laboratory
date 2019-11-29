using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MouseScreenRayProvider))]
[RequireComponent(typeof(RayCastBasedTagSelector))]
public class SelectionManager : MonoBehaviour
{
    private IRayProvider _rayProvider;
    private ISelector _selector;
    private ISelectionResponse _selectionResponse;
    private Transform _currentSelection;
    private Transform _selection;
    void Awake()
    {
        _selectionResponse = GetComponent<ISelectionResponse>();
        _selector = GetComponent<ISelector>();
        _rayProvider = GetComponent<IRayProvider>();
    }
    void Update()
    {
        try
        {
            // Debug.Log("<size=22><color=blue>lol</color></size> ");
            // Deselection/Selection Response
            if (_currentSelection != null)
                _selectionResponse.OnDeselect(_currentSelection);

            // Selection Determinationss 
            _selector.Check(_rayProvider.CreateRay());
            _currentSelection = _selector.GetSelection();

            // Deselection/Selection Response
            if (_currentSelection != null)
                _selectionResponse.OnSelect(_currentSelection);
        }
        catch (Exception e)
        {
            Debug.Log(e);
            enabled = false;
            _selectionResponse = null;
            _selector = null;
            _rayProvider = null;
            Invoke("Enable", .1f);
        }
    }
    void Enable()
    {
        enabled = true;
    }
    void OnEnable()
    {
        _selectionResponse = GetComponent<ISelectionResponse>();
        _selector = GetComponent<ISelector>();
        _rayProvider = GetComponent<IRayProvider>();
    }


}
