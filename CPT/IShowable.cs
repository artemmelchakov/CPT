using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT
{
    /// <summary>
    /// Интерфейс для всех объектов, от которых можно получить строку информации
    /// </summary>
    public interface IShowable
    {
        void Show(InfoShower infoShower);
    }
    public delegate void InfoShower(string info);
}
