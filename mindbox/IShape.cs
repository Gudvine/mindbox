using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox;

/// <summary>
/// Предоставляет фигуру
/// </summary>
public interface IShape
{
    /// <summary>
    /// Возвращает площадь фигуры
    /// </summary>
    /// <returns></returns>
    double GetArea();
}
