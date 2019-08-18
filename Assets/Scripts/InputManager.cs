using UnityEngine;
using System.Collections;

// Преобразует данные, полученные от акселерометра,
// в информацию о боковом смещении.
public class InputManager : Singleton<InputManager>
{
    // Величина смещения. -1.0 = максимально влево,
    // +1.0 = максимально вправо
    private float _sidewaysMotion = 0.0f;

    // Это свойство доступно только для чтения, поэтому
    // другие сценарии не смогут изменить его.
    public float sidewaysMotion {
        get {
            return _sidewaysMotion;
        }
    }
    // Величина отклонения сохраняется в каждом кадре
    void Update()
    {
        Vector3 accel = Input.acceleration;

        _sidewaysMotion = accel.x;
    }
}
