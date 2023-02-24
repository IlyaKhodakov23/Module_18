using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTask
{
    /// <summary>
    /// Автомобильный завод
    /// </summary>
    /// Также у вас есть класс-менеджер (director), внутри которого запускается процесс строительства:
    /// 
    class CarPlant
    {
        /// <summary>
        /// Запуск процесса постройки
        /// </summary>
        public void Construct(Conveyor conveyor)
        {
            conveyor.BuildFrame();
            conveyor.BuildEngine();
            conveyor.BuildWheels();
            conveyor.BuildDoors();
        }
    }
}
