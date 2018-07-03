using System;
using System.Linq;
using System.Windows.Forms;

namespace WorkClock
{
    partial class Displej
    {
        public enum Akcija {
            
            activate = 0,
            deactivate = 1,
            check = 2,
            uncheck =3,
            bold =4,
            normal =5,
            add = 6,
            delete = 7,
            selectOne =8,
            selectNone =9,
            select = 10,
            deselect = 11,
            dismiss = 12
        };

        public void SelectAll()
        {
            bool check = (taskListView.CheckedItems.Count != taskListView.Items.Count) ? true : false;
            foreach (ListViewItem item in taskListView.Items)
            {
                DoAction(Akcija.check, item);
            }
        }
        public void DoAction(Akcija akcija, ListViewItem i)
        {            
            switch (akcija)
            {
                case Akcija.activate:
                    DoAction(Akcija.bold, i);
                    DoAction(Akcija.check, i);
                    i.BackColor = System.Drawing.Color.CornflowerBlue; break;
                case Akcija.deactivate:
                    DoAction(Akcija.normal, i);
                    DoAction(Akcija.uncheck, i);
                    i.BackColor = System.Drawing.Color.White; break;
                case Akcija.check:
                    i.Checked = true; break;
                case Akcija.uncheck:
                    i.Checked = false; break;
                case Akcija.bold:
                    i.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));; break;
                case Akcija.normal:
                    i.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));; break;
                case Akcija.add:
                    taskListView.Items.Add(i); break;
                case Akcija.delete:
                    i.Remove(); break;
                case Akcija.selectOne:
                    foreach (ListViewItem item in taskListView.Items)
                    {
                        if (item == i)
                        {
                            DoAction(Akcija.activate, item);                            
                        }
                        else
                        {
                            DoAction(Akcija.deactivate, item);
                        }

                        DoAction(Akcija.deselect, item);
                    };
                    break;
                case Akcija.selectNone:
                    foreach (ListViewItem item in taskListView.Items)
                    {
                        DoAction(Akcija.deactivate, item);
                    };
                    break;
                case Akcija.select:
                    i.Selected = true; break;
                case Akcija.deselect:
                    i.Selected = false; break;
                case Akcija.dismiss:
                    i.Remove(); break;
            }
        }
    }
}
