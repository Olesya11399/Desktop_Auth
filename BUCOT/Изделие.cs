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
    
    public partial class Изделие
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Изделие()
        {
            this.Заказанные_изделия = new HashSet<Заказанные_изделия>();
            this.Фурнитура_изделия = new HashSet<Фурнитура_изделия>();
            this.Ткань = new HashSet<Ткань>();
        }
    
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public Nullable<double> Ширина { get; set; }
        public Nullable<double> Длина { get; set; }
        public byte[] Изображение { get; set; }
        public string Комментарий { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказанные_изделия> Заказанные_изделия { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Фурнитура_изделия> Фурнитура_изделия { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ткань> Ткань { get; set; }
    }
}
