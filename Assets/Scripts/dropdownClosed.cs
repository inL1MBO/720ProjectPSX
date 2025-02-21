using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class dropdownClosed : MonoBehaviour
{
    public Dropdown dropdown; // Assign in Inspector

    void OnEnable()
    {
        
        dropdown.Hide();
    }


}


