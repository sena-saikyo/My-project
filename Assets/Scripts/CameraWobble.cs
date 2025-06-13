using UnityEngine;

/// <summary>
/// Provides a subtle horizontal wobble effect to induce mild VR motion sickness.
/// Attach this script to the Main Camera in the XR Origin.
/// </summary>
public class CameraWobble : MonoBehaviour
{
    [Tooltip("Wobble amplitude in meters")]
    public float amplitude = 0.01f;

    [Tooltip("Wobble frequency in Hz")]
    public float frequency = 1.0f;

    Vector3 m_InitialLocalPosition;

    void Start()
    {
        m_InitialLocalPosition = transform.localPosition;
    }

    void Update()
    {
        float time = Time.time * frequency * Mathf.PI * 2f;
        float offset = Mathf.Sin(time) * amplitude;
        transform.localPosition = m_InitialLocalPosition + transform.right * offset;
    }
}
