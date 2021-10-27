using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHighlight : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material originalMaterial;
    public Material highlightMaterial;


    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;       // pour sauvegarder material original 
        
    }

    void OnMouseOver()
    {
        meshRenderer.material = highlightMaterial;
    }

    void OnMouseExit()
    {
        meshRenderer.material = originalMaterial;
    }
}
