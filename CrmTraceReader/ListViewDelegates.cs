using System.Collections.Generic;
using System.Windows.Forms;

namespace CrmTraceReader
{
    public class ListViewDelegates
    {
        public static void AddItem(ListView listview, ListViewItem item)
        {
            MethodInvoker miAddItem = delegate
            {
                listview.Items.Add(item);
            };

            if (listview.InvokeRequired)
            {
                listview.Invoke(miAddItem);
            }
            else
            {
                miAddItem();
            }
        }

        public static void ClearItems(ListView listview)
        {
            MethodInvoker miClearItems = delegate
            {
                listview.Items.Clear();
            };

            if (listview.InvokeRequired)
            {
                listview.Invoke(miClearItems);
            }
            else
            {
                miClearItems();
            }
        }

        internal static void AddRange(ListView listview, List<ListViewItem> lvis)
        {
            MethodInvoker miAddItem = delegate
            {
                listview.Items.AddRange(lvis.ToArray());
            };

            if (listview.InvokeRequired)
            {
                listview.Invoke(miAddItem);
            }
            else
            {
                miAddItem();
            }
        }
    }
}
