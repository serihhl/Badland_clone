using NUnit.Framework;
using Unity.Scripting.LifecycleManagement;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    character character;
    public List<PickUpItemType> charaterItems;
    
    public void PickUpActivated(PickUpItemType pickup) {

       if (charaterItems.Contains(pickup)) {
            character.PickUpActivated(pickup);
        }

    }

    private void Start() {

        character = FindAnyObjectByType<character>();

    }

}
