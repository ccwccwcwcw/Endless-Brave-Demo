using UnityEngine.XR;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject ItemInSlot;
    public Image slotImage;
    private float gripValue;
    private InputDevice inputDevice;
    Color originalColor;
    void Start()
    {
        slotImage = GetComponentInChildren<Image>();
        originalColor = slotImage.color;
    }

    private void OnTriggerStay(Collider other)
    {
        inputDevice.TryGetFeatureValue(CommonUsages.grip, out gripValue);
        if (ItemInSlot != null) return;
        GameObject obj = other.gameObject;
        if (!IsItem(obj)) return;
        if (gripValue == 0)
        {
            InsertItem(obj);
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (gameObject.GetComponent<Item>() == null) return;
    //    if (gameObject.GetComponent<Item>().inSlot)
    //    {
    //        gameObject.GetComponentInParent<Slot>().ItemInSlot = null;
    //        gameObject.transform.parent = null;
    //        gameObject.GetComponent<Item>().inSlot = false;
    //        gameObject.GetComponent<Item>().currentSlot.ResetColor();
    //        gameObject.GetComponent<Item>().currentSlot = null;
    //    }
    //}

    bool IsItem(GameObject obj)
    {
        return obj.GetComponent<Item>();
    }

    void InsertItem(GameObject obj)
    {
        obj.GetComponent<Rigidbody>().isKinematic = true;
        obj.transform.SetParent(gameObject.transform, true);
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;
        obj.GetComponent<Item>().inSlot = true;
        obj.GetComponent<Item>().currentSlot = this;
        ItemInSlot = obj;
        slotImage.color = Color.grey;

    }
    public void ResetColor()
    {
        slotImage.color = originalColor;
    }
}
