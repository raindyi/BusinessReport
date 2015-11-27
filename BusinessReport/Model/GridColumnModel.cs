using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.UI.Model
{
    public class GridColumnModel
    {
        /// <summary>
        /// Gets or sets the data bind name of the grid
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the head title of the grid
        /// </summary>
        public String HeadName { get; set; }
        /// <summary>
        /// Gets or sets the editable of the grid,default value is true
        /// </summary>
        public Boolean CanEdit { get; set; }
        /// <summary>
        /// Gets or sets the visible of the grid,default value is false
        /// </summary>
        public Boolean Visible { get; set; }
        /// <summary>
        /// Gets or sets the width of the grid,default value is 40
        /// </summary>
        public Int32 Width { get; set; }
        /// <summary>
        /// Gets or sets the type of the grid column,default value is string
        /// </summary>
        public Type DataType { get; set; }

        public GridColumnModel()
        {
            CanEdit = false;
            Visible = true;
            Width = 40;
            DataType = typeof(String);
        }
    }
}
