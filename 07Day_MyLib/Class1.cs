using System;

namespace _07Day_MyLib
{
    // Define custom Table attribute
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string TableName { get; set; }
    }

    // Define custom Column attribute
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
    }

    [Table(TableName = "Employee")]
    public class Emp
    {
        private string _Name;
        private string _Address;

        [Column(ColumnName = "EId", ColumnType = "int")]
        public int Id { get; set; }

        [Column(ColumnName = "EName", ColumnType = "varchar(50)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [Column(ColumnName = "EAddress", ColumnType = "varchar(50)")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
