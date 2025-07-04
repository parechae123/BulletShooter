using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class MaterialSwap : MonoBehaviour
{
    public Material[] cloakingMats;
    public Material[] defaultMats;
    public SkinnedMeshRenderer mesh;
    void Start()
    {
        defaultMats = mesh.materials;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("dd");

            mesh.SetMaterials(cloakingMats.ToList());
        }
    }
}
