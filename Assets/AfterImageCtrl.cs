using UnityEngine;

public class AfterImageController : MonoBehaviour
{
    [Header("AfterImage Material")]
    public Material afterImageMaterial;

    [Header("Settings")]
    public Color color = Color.red;
    [Range(0f, 1f)] public float alpha = 0.6f;
    [Range(0f, 10f)] public float rimLightMul = 0.5f;
    [Range(0f, 10f)] public float rimLightPow = 1.5f;
    [Range(0f, 10f)] public float intensity = 1.0f;

    void Start()
    {
        if (afterImageMaterial == null)
        {
            Debug.LogError("AfterImage Material not assigned!");
            return;
        }

        ApplySettings();
    }

    void ApplySettings()
    {
        afterImageMaterial.SetColor("_Color", color);
        afterImageMaterial.SetFloat("_Alpha", alpha);
        afterImageMaterial.SetFloat("_RimLightMul", rimLightMul);
        afterImageMaterial.SetFloat("_RimLightPow", rimLightPow);
        afterImageMaterial.SetFloat("_Intensity", intensity);
    }

    // 예: 실행 중 값 변경 가능
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            alpha = Mathf.PingPong(Time.time, 1f); // 예제: 알파 흔들기
            ApplySettings();
        }
    }
}
