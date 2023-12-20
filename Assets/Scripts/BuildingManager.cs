using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{

  [SerializeField] private BuildingTypeSO buildingType;
  private Camera mainCamera;

  private void Start()
  {
    mainCamera = Camera.main;
  }


  private void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Instantiate(buildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
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
