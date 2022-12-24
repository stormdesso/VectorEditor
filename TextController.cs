using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VectorEditor
{
    class TextController : IText
    {

        private SelectionStore selStore;

        public TextController(SelectionStore _selStore)
        {
            SelStore = _selStore;            
        }

        public SelectionStore SelStore
        {
            get { return selStore; }
            set { selStore = value; }
        }

        string IText.SetCurrentTextInTextBox()
        {
            MySelection activeSelection = SelStore.ActiveSelection;

            if (activeSelection != null)
            {
                if (activeSelection is TextSelection)
                {
                    return (((Text)(activeSelection.Item)).TextValue);
                }
            }
            return null;
        }

        void IText.UpdateText(string text)
        {
            MySelection activeSelection = SelStore.ActiveSelection;

            if (activeSelection != null)
            {
                if (activeSelection is TextSelection)
                {
                    ((Text)activeSelection.Item).TextValue = text;
                }
            }            
        }
    }
}
