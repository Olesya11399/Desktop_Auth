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
    
    public partial class Заказанные_изделия
    {
        public string Артикул_изделия { get; set; }
        public int Номер_заказа { get; set; }
        public int Количество { get; set; }
    
        public virtual Заказ Заказ { get; set; }
        public virtual Изделие Изделие { get; set; }
    }
}
