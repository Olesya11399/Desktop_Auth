//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BUCOT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Фурнитура_изделия
    {
        public string Артикул_фурнитуры { get; set; }
        public string Артикул_изделия { get; set; }
        public string Размещение { get; set; }
        public string Ширина { get; set; }
        public string Длина { get; set; }
        public Nullable<double> Поворот { get; set; }
        public int Количество { get; set; }
    
        public virtual Изделие Изделие { get; set; }
        public virtual Фурнитура Фурнитура { get; set; }
    }
}
