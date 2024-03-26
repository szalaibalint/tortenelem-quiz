using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz.Controls
{
    
    public partial class OrderQuestionControl : UserControl, IQuestionControl
    {
        OrderQuestion question;
        public OrderQuestionControl(OrderQuestion question)
        {
            InitializeComponent();

            this.question = question;
            questionTb.Text = question.Text;
            listBox1.Items.Add(question.Answers[0].text);
            listBox1.Items.Add(question.Answers[1].text);
            listBox1.Items.Add(question.Answers[2].text);
            listBox1.Items.Add(question.Answers[3].text);
            listBox1.Items.Add(question.Answers[4].text);
            Controls.Add(listBox1);
            this.listBox1.AllowDrop = true;
            this.listBox1.MouseDown += new MouseEventHandler(listBox1_MouseDown);
            this.listBox1.DragEnter += new DragEventHandler(listBox1_DragEnter);
            this.listBox1.DragOver += new DragEventHandler(listBox1_DragEnter);
            this.listBox1.DragDrop += new DragEventHandler(listBox1_DragDrop);
        }
        
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Test whether the mouse is over an item.
            if (this.GetItemIndexAtPoint(e.Location) != -1)
            {
                // The mouse is over an item so start dragging.
                this.listBox1.DoDragDrop(this.listBox1, DragDropEffects.Move);
            }
        }
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            // Test whether the data being dragged is the ListBox itself.
            if (e.Data.GetDataPresent("System.Windows.Forms.ListBox") &&
                e.Data.GetData("System.Windows.Forms.ListBox") == this.listBox1)
            {
                // Get the location of the mouse relative to the ListBox.
                Point mouseLocation = this.listBox1.PointToClient(new Point(e.X, e.Y));
                // Force the location to be within the horizontal bounds of the ListBox.
                if (mouseLocation.X < 0)
                {
                    mouseLocation.X = 0;
                }
                else if (mouseLocation.X > this.listBox1.Width)
                {
                    mouseLocation.X = this.listBox1.Width;
                }
                // Force the location to be within the vertical bounds of the ListBox.
                if (mouseLocation.Y < 0)
                {
                    mouseLocation.Y = 0;
                }
                else if (mouseLocation.Y > this.listBox1.Height)
                {
                    mouseLocation.Y = this.listBox1.Height;
                }

                if (this.GetItemIndexAtPoint(mouseLocation) == this.listBox1.SelectedIndex)
                {
                    // Don't allow the selected item to be dropped on itself.
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    // Allow the selected item to be moved.
                    e.Effect = DragDropEffects.Move;
                }

            }
        }
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            // Test whether the data being dragged is the ListBox itself and the selected item can be moved.
            if (e.AllowedEffect == DragDropEffects.Move &&
                e.Data.GetDataPresent("System.Windows.Forms.ListBox") &&
                e.Data.GetData("System.Windows.Forms.ListBox") == this.listBox1)
            {
                int selectedIndex = this.listBox1.SelectedIndex;

                // Get the index of the item being dropped on.
                int dropIndex = this.GetItemIndexAtPoint(this.listBox1.PointToClient(new Point(e.X, e.Y)));

                // If the item being dropped on is below the selected item, the index of the
                // item being dropped on will decrement once the selected item is removed.
                if (dropIndex > selectedIndex)
                {
                    dropIndex -= 1;
                }

                object selectedItem = this.listBox1.SelectedItem;

                this.listBox1.Items.Remove(selectedItem);

                if (dropIndex == -1)
                {
                    // The item was dropped after the last item so add it at the end of the list.
                    this.listBox1.Items.Add(selectedItem);
                }
                else
                {
                    // Insert the item above the item it was dropped on.
                    this.listBox1.Items.Insert(dropIndex, selectedItem);
                }
                // as



                this.listBox1.SelectedItem = selectedItem;

            }



        }
        private int GetItemIndexAtPoint(Point location)
        {
            int itemIndex = -1;

            for (int index = 0; index < this.listBox1.Items.Count; index++)
            {
                // Test whether the location is within an item.
                if (this.listBox1.GetItemRectangle(index).Contains(location))
                {
                    itemIndex = index;
                    break;
                }
            }
            return itemIndex;
        }

        public bool IsCorrect()
        {
            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                for (int j = 0; j < question.Answers.Count; j++)
                {
                    if (question.Answers[j].text == listBox1.Items[i].ToString())
                    {
                        if (question.Answers[j].correct != i+1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public bool isSelected()
        {
            return true;
        }
    }
}
