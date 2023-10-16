using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productType"> идентификатор типа продукции</param>
        /// <param name="materialType">идентификатор типа материала</param>
        /// <param name="count">количество необходимой продукции для производства</param>
        /// <param name="width">ширину продукции </param>
        /// <param name="length">длину продукции</param>
        /// <returns>возвращать целое число - количество необходимого сырья с учетом возможного брака сырья</returns>
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (String.IsNullOrWhiteSpace(Convert.ToString(productType)) || String.IsNullOrWhiteSpace(Convert.ToString(materialType)) || String.IsNullOrWhiteSpace(Convert.ToString(count)) || String.IsNullOrWhiteSpace(Convert.ToString(width)) || String.IsNullOrWhiteSpace(Convert.ToString(length)))
            {
                return -1;
            }

            if(productType<=0||materialType<=0||count<=0||width<=0||length<=0)
            {
                return -1;
            }

            double productTypeСoefficient = 0;
            double materialTypeСoefficient = 0;
            int work = 1;
            double a=1;

            if (productType==1)
            {
                productTypeСoefficient = 1.1;

            }
            else if (productType==2)
            {
                productTypeСoefficient = 2.5;
            }
            else if (productType==3)
            {
                productTypeСoefficient = 8.43;
            }
            else if(productType<=0||productType>=4)
            { 
                return -1;
            }

            if (materialType == 1)
            {
                materialTypeСoefficient = 0.3 / 100;
            }
            else if(materialType==2)
            {
                materialTypeСoefficient = 0.12 / 100;
            }
            else if (materialType<=0||materialType>=3)
            {
                return -1;
            }

            a =  productType * productTypeСoefficient * count * width * length;
            work =Convert.ToInt32 ((a * materialTypeСoefficient) + a);

            return work;
        }
    }
}
