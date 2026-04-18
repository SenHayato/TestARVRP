using UnityEngine;

public class GyroSetting : MonoBehaviour
{
    public void SetRotation(string data)
    {
        string[] values = data.Split(',');

        float x = float.Parse(values[0]);
        float y = float.Parse(values[1]);
        float z = float.Parse(values[2]);

        transform.rotation = Quaternion.Euler(x, y, z);
    }
}
