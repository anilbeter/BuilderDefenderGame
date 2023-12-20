using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
  private Dictionary<ResourceTypeSO, int> resourceAmountDictionary;

  private void Awake()
  {
    resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();

    ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(nameof(ResourceTypeListSO));

    foreach (ResourceTypeSO resourceType in resourceTypeList.list)
    {
      //   Debug.Log(resourceType);
      /*
      Wood
      Stone
      Gold
      */

      resourceAmountDictionary[resourceType] = 0;
      // Wood, Stone ve Gold (resources)'ların value'yu 0'a eşitledim (Gold: 0, Wood: 0, ...)
    }
    TestLogResourceAmountDictionary();
  }

  private void TestLogResourceAmountDictionary()
  {
    foreach (ResourceTypeSO resourceType in resourceAmountDictionary.Keys)
    {
      Debug.Log(resourceType.nameString + ": " + resourceAmountDictionary[resourceType]);
    }
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.T))
    {
      ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(nameof(ResourceTypeListSO));
      AddResource(resourceTypeList.list[0], 2);
      TestLogResourceAmountDictionary();
    }
  }

  public void AddResource(ResourceTypeSO resourceType, int amount)
  {
    resourceAmountDictionary[resourceType] += amount;
  }
}
