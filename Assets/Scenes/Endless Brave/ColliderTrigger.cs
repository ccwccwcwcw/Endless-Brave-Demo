using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public float timeLimit = 2f; // 触发时间限制
    public List<Light> lights = new List<Light>(); // 灯光列表
    public Color redColor = Color.red; // 红色灯光颜色
    public Color blueColor = Color.blue; // 蓝色灯光颜色
    public Color yellowColor = Color.yellow; // 黃色灯光颜色
    private static int triggerCount = 0; // 触发数量

    private void Start()
    {
        // 获取灯光组件
        foreach (Transform child in transform)
        {
            Light light = child.GetComponent<Light>();
            if (light != null)
            {
                lights.Add(light);
                light.enabled = false;
            }
        }
        // 设置常态灯光为看不见状态
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerCount++;
        if (triggerCount == 3)
        {
            foreach (Light light in lights)
            {
                light.color = yellowColor;
                light.enabled = true;
            }
            StartCoroutine(DisableAllLights());
        }
        else if (triggerCount == 2)
        {
            foreach (Light light in lights)
            {
                light.color = blueColor;
                light.enabled = true;
            }
            StartCoroutine(ResetTriggerCount());
        }
        else if (triggerCount == 1)
        {
            foreach (Light light in lights)
            {
                light.color = redColor;
                light.enabled = true;
            }
            StartCoroutine(ResetTriggerCount());
        }
    }

    IEnumerator ResetTriggerCount()
    {
        yield return new WaitForSeconds(timeLimit);
        triggerCount--;
        if (triggerCount < 0)
        {
            triggerCount = 0;
        }
        // 设置常态灯光为看不见状态
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
    }

    IEnumerator DisableAllLights()
    {
        yield return new WaitForSeconds(timeLimit);
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
        triggerCount = 0;
        // 设置常态灯光为看不见状态
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
    }
}
