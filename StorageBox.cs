using System.Collections.Generic;

namespace VendingMachineEmulator
{
    public class StorageBox<T> where T : struct
    {

        protected Dictionary<T, int> items;

        public virtual int this[T item]
        {
            get { return items[item]; }
            set { items[item] = value; }
        }

        public StorageBox()
        {
            items = new Dictionary<T, int>();
        }

        public virtual bool isEmpty
        {
            get
            {
                return (items == null || items.Count == 0);
            }
        }

        public virtual bool Contains(T item)
        {
            return items.ContainsKey(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public override string ToString()
        {
            if (!isEmpty)
            {
                var sb = new System.Text.StringBuilder();

                foreach (var item in items)
                {
                    sb.AppendFormat("{0}\t{1}", item.Key.ToString(), item.Value);
                    sb.Append("\n");
                }
                sb.AppendLine();

                return sb.ToString();
            }
            else
            {
                return "Пусто...";
            }
        }
    }
}
