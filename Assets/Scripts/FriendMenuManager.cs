﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FriendMenuManager : MonoBehaviour
{
    public GameObject friendEntryPrefab;

    public List<string> friendCodes = new List<string>();

    public GameObject listParent;
    private Transform _listParentTransform;

    // Start is called before the first frame update
    void Awake()
    {
        _listParentTransform = listParent.transform;
    }

    private void OnEnable()
    {
        RefreshPlayerList();
    }

    private void RefreshPlayerList()
    {
        RebuildUI();
    }

    private void RebuildUI()
    {
        foreach (Transform t in _listParentTransform)
            Destroy(t.gameObject);

        foreach (FriendDataResponse data in BrickServerInterface.GetInstance())
        {
            GameObject newPlayerEntry = Instantiate(friendEntryPrefab, _listParentTransform);
            FriendListItem playerListItem = newPlayerEntry.GetComponent<FriendListItem>();
            playerListItem.Initialize(data);
        }
    }
}

public class FriendDataResponse {

}
