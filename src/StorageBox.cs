using System.Collections.Generic;
using System.Linq;

namespace VendingMachine.Parts
{
    public class StorageBox<T> where T : struct
    {
        /**
         * Similar to table that store T type as key
         * and int for amount of T type goods
         */
        protected Dictionary<T, int> items;

        // Easy access to dictionary ~ sb[0]
        public virtual int this[T item] {
            get { return items[item]; }
            set { items[item] = value; }
        }

        public StorageBox() {
            items = new Dictionary<T, int>();
        }

        public int getAmount(int index) {
            return items.ElementAt(index).Value;
        }

        public virtual bool isEmpty {
            get { return items.Count == 0; }
        }

        /**
         * Return true if T type good is stored
         * and amount of it more than 0
         * @param {any} T item
         */
        public virtual bool Contains(T item) {
            return (items.ContainsKey(item) && items[item] > 0);
        }

        // Delete all goods from dictionary
        public void Clear() {
            items.Clear();
        }

        // Return whole dictionary "key  value" as string
        public override string ToString() {
            if (!isEmpty) {
                var sb = new System.Text.StringBuilder();

                foreach (var item in items) {
                    sb.AppendFormat("{0}\t{1}", item.Key.ToString(), item.Value);
                    sb.Append("\n");
                }
                sb.AppendLine();

                return sb.ToString();
            } else {
                return "Empty...";
            }
        }
    }
}
