﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorEditor.Model.Class;
using VectorEditor.Model.Class.GeometryObject;

namespace VectorEditor
{
    class SelectionsController : ISelections
    {
        public SelectionsController(SelectionStore ss, Store s)
        {
            SelectionStore = ss;  
            Store= s;
        }
                
        private SelectionStore selectionStore;
        public SelectionStore SelectionStore
        {
            get { return selectionStore; }
            private set { selectionStore = value; }
        }

        private Store store;
        public Store Store
        {
            get { return store; }
            set { store = value; }
        }

        public int Count
        { 
            get 
            {
                int count = 0;
                foreach (MySelection item in SelectionStore)
                {
                    if (item.IsGrab || item.bodyIsActive)
                        count++;                      
                }
                return count;
            } 
        }

        public void SelectAndGrabItem(GraphItem item, int x, int y)
        {
            MySelection s = item.CreateSelection();
            SelectionStore.Add(s);
            SelectionStore.TryGrab(x, y);              
        }

        void ISelections.DeleteSelections()
        {
            SelectionStore.Clear();
        }

        void ISelections.DragSelectionsTo(int x, int y)
        {
            if (SelectionStore.ActiveSelection != null)
            {                
                if (SelectionStore.ActiveSelection.TryDragTo(x, y))
                {
                    //Console.WriteLine("Координаты изменились!");                                        
                }
            }
               
        }

        void ISelections.ReleaseSelection()
        {
            SelectionStore.Release();
        }

        bool ISelections.TryGrab(int x, int y)
        {
            MySelection activeSelection = SelectionStore.TryGrab(x, y);

            if (activeSelection != null)
            {
                foreach (MySelection item in SelectionStore)
                {
                    if (item != activeSelection)
                        item.ReleaseGrab();
                }

                return true;
            }
            return false;
        }

        public bool TrySelect(int x, int y, bool CtrlIsPressed)
        {

            if (!CtrlIsPressed)            
                foreach (MySelection item in SelectionStore)                
                   item.ReleaseGrab();
                            
            GraphItem itemInThisPoint = Store.Item(x, y);
            foreach (MySelection item in SelectionStore)
            {
                if (item.Item == itemInThisPoint)
                {
                    item.bodyIsActive = true;
                    item.IsGrab = false;
                    return true;
                }
            }

            return false;
        }

        public bool Grouping()
        {
            List<GraphItem> selectItems = SelectionStore.GetSelectItems();

            if (selectItems.Count > 1)
            {
                Group g = Factory.NewGroup(new List<GraphItem>(selectItems));                
                
                /*
                // лучше переместить в конструктор группы
                //g.graphItems.AddRange(new List<GraphItem>(selectItems));                                
                //foreach (var item in g.graphItems)
                //{
                //     item.SetLocalFrame(g.Frame);
                //}
                //g.ChangeItemsInGroup();
                //
                */

                DeleteSelectedItems();
                SelectionStore.Add(g.CreateSelection());
                Store.Add(g);

                return true;
            }

            return false;
        }

        public bool Ungrouping()
        {
            List<GraphItem> selectItems = SelectionStore.GetSelectItems();         

            if (selectItems.Count == 1)
            {
                if (selectItems[0] is Group)
                {
                    Group selectGroup = (Group)selectItems[0];
                    DeleteSelectedItems();
                    Store.AddRange(selectGroup.graphItems);

                    foreach (GraphItem item in selectGroup.graphItems)                    
                        SelectionStore.Add(item.CreateSelection());
                    
                    return true;
                }
            }

            return false;
        }

        public void DeleteSelectedItems()
        {
            List<GraphItem> selectItems = SelectionStore.GetSelectItems();

            int i = 0;
            while ( i < SelectionStore.Count)
            {
                if (SelectionStore[i].IsGrab || SelectionStore[i].bodyIsActive)
                {
                    SelectionStore.Remove(SelectionStore[i]);
                    continue;
                }
                i++;
            }
                            
            Store.Delete(selectItems);
        }
    }
}
