using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
  // Reference for WoodHarvester prefab
  [SerializeField] private Transform pfWoodHarvester;
  private Camera mainCamera;

  private void Start()
  {
    mainCamera = Camera.main;
  }


  private void Update()
  {
    // Spawn WoodHarvester object at current mouse cursor position when clicked left mouse button, with no rotation(Quaternion.identity)
    if (Input.GetMouseButtonDown(0))
    {
      Instantiate(pfWoodHarvester, GetMouseWorldPosition(), Quaternion.identity);
    }
  }

  // Get mouse position 
  private Vector3 GetMouseWorldPosition()
  {
    Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    mouseWorldPosition.z = 0;
    return mouseWorldPosition;
  }
}
