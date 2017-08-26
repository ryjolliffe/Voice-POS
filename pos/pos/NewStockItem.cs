using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos
{
    class NewStockItem
    {
        string _itemName;
        string _subProperty1;
        string _subProperty2;
        string _subproperty3;
        int _subProperty1Price;
        int _subProperty2Price;
        int _subProperty3Price;

        public string ItemName
        {
            get {return _itemName; }
            set {_itemName = value; }
        }
        public string SubProp1
        {
            get { return _subProperty1; }
            set { _subProperty1 = value; }
        }
        public string SubProp2
        
        {
            get { return _subProperty2; }
            set { _subProperty2 = value; }
        }
        public string SubProp3
        {
            get { return _subproperty3; }
            set {_subproperty3 = value; }
        }
        public int SubProp1Price1
        {
            get {return _subProperty1Price; }
            set {_subProperty1Price = value; }
        }
        public int SubProp1Price2
        {
            get { return _subProperty2Price; }
            set { _subProperty2Price = value; }
        }
        public int SubProp1Price3
        {
            get { return _subProperty3Price; }
            set { _subProperty3Price = value; }
        }

        public NewStockItem(string _itemname, string _subPropert1, int _subProprty1Price, string _subPropert2, int _subPropert2Price, string _subProperty3, int _subProprty3Price)

    }
}
