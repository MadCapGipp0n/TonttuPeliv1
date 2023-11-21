// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ItempickUp : MonoBehaviour
// {
//     [SerializeField] Item item;
//     [SerializeField] Inventory inventory; 
//     [SerializeField] KeyCode itemPickUpKeyCode = KeyCode.E;
//     private bool isInRange;
//     private bool isEmpty;
    
//     private void Update()
//         {
//             if (isInRange && input.GetKeyDown(itemPickUpKeyCode))
//            {
//             if (!isEmpty)
//                 {
//                     inventory.AddItem(item);
//                     isEmpty = true;
//                 }
//             }
//         }
    

//     private void OnTriggerEnter(Collider other)
//     {
//         isInRange =True;
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         isInRange =False;
//     }
// }
