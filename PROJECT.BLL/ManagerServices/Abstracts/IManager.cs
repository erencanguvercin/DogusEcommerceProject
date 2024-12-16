using PROJECT.ENTITIES.Interfaces;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BLL.ManagerServices.Abstracts
{
    public interface IManager<T> where T : class, IEntity
    {
        //List Commands
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetModifieds();
        IQueryable<T> GetPassives();

        //Modify Commands: Task bir komutu void tipinde fakat asenkron bir şekilde çalışacağını belirtir.
        string Add(T item);

        Task AddAsync(T item);
        Task AddRangeAsync(List<T> list);
        Task UpdateAsync(T item);
        Task UpdateRangeAsync(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);

        void Destroy(T item); //RemoveAsync varsa void'i Task'e çevir.

        void DestroyRange(List<T> list);

        //Linq Commands

        IQueryable<T> Where(Expression<Func<T, bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);

        //Bir ifade ağacı oluşturulur. Bu ağaçta T türündeki bir nesnenin uygulanacağı sorguya istinaden bir boolean değer döneceği ifade edilir.
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);

        //Burada ise Select metodu veritabanı tablolarından elde edilmek istenen verilerin yapılan sorguya göre getirileceği bir metot olduğu için T değil X yani dönüştürülmüş değer (projeksiyonlanmış veya değişime uğramış değer) şeklinde ifade ederiz.
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        //Find

        Task<T> FindAsync(int id);
    }
}
