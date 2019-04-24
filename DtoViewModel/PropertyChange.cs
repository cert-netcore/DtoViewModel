using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DtoViewModel.AttributeUtils;
using DtoViewModel.Interface;
using DtoViewModel.Models;

namespace DtoViewModel
{
    public class PropertyChange : Property,IPropertyChange
    {
        private TModel GetClassIns<TModel>(Type type) where TModel : class
        {
          
        }


        /// <summary>
        /// 映射关系
        /// </summary>
        /// <typeparam name="TModel">模型类</typeparam>
        /// <typeparam name="TViewModel">ViewModel类</typeparam>
        public void Change<TModel, TViewModel>() where TModel : class where TViewModel : class
        {
            var classAttribute = typeof(TModel).GetCustomAttribute(typeof(DtoClassAttribute)) as DtoClassAttribute;
            if (classAttribute == null)
            {
                //todo create Error Class
                // not patten
                throw new Exception("Fail");
            }
            //todo find the viewModel Class

            Assembly asm = Assembly.GetAssembly(typeof(DtoClassAttribute));
            Type[] types = asm.GetExportedTypes();



        }






    }
}
