﻿// PROJECT : MsCrmTools.AttributeBulkUpdater
// This project was developed by Tanguy Touzard
// CODEPLEX: http://xrmtoolbox.codeplex.com
// BLOG: http://mscrmtools.blogspot.com

using System;
using System.Collections;
using System.Windows.Forms;

namespace CrmTraceReader
{
    /// <summary>
    /// Compares two listview items for sorting
    /// </summary>
    class ListViewItemComparer : IComparer
    {
        #region Variables

        /// <summary>
        /// Index of sorting column
        /// </summary>
        private readonly int col;

        private bool isDateCompare = true;

        /// <summary>
        /// Sort order
        /// </summary>
        private readonly SortOrder innerOrder;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of class ListViewItemComparer
        /// </summary>
        public ListViewItemComparer()
        {
            col = 0;
            innerOrder = SortOrder.Ascending;
        }

        /// <summary>
        /// Initializes a new instance of class ListViewItemComparer
        /// </summary>
        /// <param name="column">Index of sorting column</param>
        /// <param name="order">Sort order</param>
        public ListViewItemComparer(int column,SortOrder order)
        {
            isDateCompare = column == 0;

            col = column;
            innerOrder = order;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Compare tow objects
        /// </summary>
        /// <param name="x">object 1</param>
        /// <param name="y">object 2</param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            return Compare((ListViewItem)x, (ListViewItem)y);
        }

        /// <summary>
        /// Compare tow listview items
        /// </summary>
        /// <param name="x">Listview item 1</param>
        /// <param name="y">Listview item 2</param>
        /// <returns></returns>
        public int Compare(ListViewItem x, ListViewItem y)
        {
            if (isDateCompare)
            {
                if (innerOrder == SortOrder.Ascending)
                {
                    return DateTime.Compare(DateTime.Parse(x.SubItems[col].Text), DateTime.Parse(y.SubItems[col].Text));
                }

                return DateTime.Compare(DateTime.Parse(y.SubItems[col].Text), DateTime.Parse(x.SubItems[col].Text));
            }

            if (innerOrder == SortOrder.Ascending)
            {
                return String.Compare(x.SubItems[col].Text, y.SubItems[col].Text);
            }
            return String.Compare(y.SubItems[col].Text, x.SubItems[col].Text);
        }

        #endregion
    }
}