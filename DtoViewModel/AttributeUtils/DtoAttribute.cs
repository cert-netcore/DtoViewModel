using System;
using System.Collections.Generic;
using System.Text;

namespace DtoViewModel.AttributeUtils
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = false,Inherited = true)]
    public sealed class DtoClassAttribute:Attribute
    {
        public DtoClassAttribute()
        {
            
        }

        public DtoClassAttribute(string className)
        {
            this.className = className;
        }

        private string className;
        public string ClassName
        {
            get { return className;}
            set { className = value; }
        }
    }


    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public sealed class DtoFieldAttribute : Attribute
    {
        public DtoFieldAttribute()
        {
            
        }

        public DtoFieldAttribute(string fieldName)
        {
            this.fieldName = fieldName;
        }

        private string fieldName;
        public string FieldName
        {
            get { return fieldName;}
            set { fieldName = value; }
        }
    }






}
