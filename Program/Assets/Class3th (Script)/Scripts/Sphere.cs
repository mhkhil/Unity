using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private float weight;

    public float radius = 15;

    private void Awake()
    {
        // Awake 함수란?
        // 게임 오브젝트가 생성된 시점에 단 한 번만
        // 호출되며 스크립트가 비활성화된 상태일 때도
        // 호출되는 이벤트 함수입니다.
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        // OnEnable 함수란?
        // 게임 오브젝트가 활성화되는 시점에 호출되는
        // 이벤트 함수입니다.

        Debug.Log("OnEnable");
    }
    private void Start()
    {
        // Start 함수란?
        // 게임 오브젝트가 생성되는 시점에 단 한 번만 호출되며,
        // 스크립트가 비활성화된 상태일 때 호출되지 않은 이벤트 함수입니다.

        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        // FixedUpdate 함수란?
        // timestep에 설정된 값에 따라 일정한 간격으로 호출되는
        // 이벤트 함수입니다.

        Debug.Log("Fixed Update");
    }
    private void Update()
    {
        // Update 함수란?
        // 매 프레임마다 호출되며, 기기의 성능에 따라 Framerate
        // 바뀔 수 있는 이벤트 함수입니다.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate 함수란?
        // Update 함수가 호출되고 그 다음으로 매 프레임마다 호출되는
        // 이벤트 함수입니다.

        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable 함수란?
        // 게임 오브젝트가 비활성화되었을 때
        // 호출되는 이벤트 함수입니다.

        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        // OnDestroy 함수란?
        // 게임 오브젝트가 삭제되었을 때
        // 호출되는 이벤트 함수입니다.

        Debug.Log("OnDestroy");
    }
}