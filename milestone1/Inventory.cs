using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone1
{
    class Inventory
    {
        //Atribute Fields
        private string _itemName;
        private double _itemPrice;
        private string _itemSize;
        private string _customerComment;
        private string _productCategory;
        private string[] _searchTags;

        //Constructor Method
        public Inventory()
        {

        }

        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public double itemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }

        public string itemSize
        {
            get { return _itemSize; }
            set { _itemSize = value; }
        }

        public string customerComment
        {
            get { return _customerComment; }
            set { _customerComment = value; }
        }

        public string productCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; }
        }

        public string[] searchTags 
        {
            get { return _searchTags; }
            set { _searchTags = value; }
        }

    }
}
