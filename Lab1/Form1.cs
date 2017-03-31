using Lab1.Toys;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private List<Object> objectList = new List<Object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void add(object sender, EventArgs e)
        {
            String selectedItem = (string)classList.SelectedItem;
            if (selectedItem == null) {return;} 
            Object obj = null;
            if (selectedItem.Equals("Car"))
            {
                obj = new Car();
            }else if (selectedItem.Equals("Plane"))
            {
                obj = new Plane();
            }
            else if (selectedItem.Equals("Submarine"))
            {
                obj = new Submarine();
            }
            else if (selectedItem.Equals("Computer"))
            {
                obj = new Computer();
            }
            if (obj != null)
            {
                objectComboBox.Items.Add(obj);
            }
             
        }

        private void objectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = objectComboBox.SelectedItem.GetType().Name;
            panel.Controls.Clear();
            panel2.Controls.Clear();
            
            Type t = objectComboBox.SelectedItem.GetType();
            Object selectedItem = objectComboBox.SelectedItem;

            var interfaces = t.GetInterfaces();
            int x = 0;
            int y = 0;
            Point labelPoint = new Point(x, y);
            Point buttonPoint = new Point(x, y);

            bool isSpeedDisplayed = false;
            bool isHeighDisplayed = false;
            
            foreach (Type i in interfaces)
            {
                if (i.Equals(typeof(IAccelerate)))
                {
                    IAccelerate iAccelerate = (IAccelerate)selectedItem;

                    if (!isSpeedDisplayed) {
                        CreateLabel("Speed: " + iAccelerate.getSpeed(), labelPoint);
                        isSpeedDisplayed = true;
                        labelPoint.Y += 25;
                    }
                    Button accelerate = new Button();
                    accelerate.Click += AccelerateClick;
                    accelerate.Text = "Accelerate";
                    accelerate.Location = buttonPoint;
                    panel2.Controls.Add(accelerate);
                    buttonPoint.Y += 25;

                }
                else if (i.Equals(typeof(ISlowDown)))
                {
                    ISlowDown iSlowDown = (ISlowDown)selectedItem;
                    if (!isSpeedDisplayed)
                    {
                        CreateLabel("Speed: " + iSlowDown.getSpeed(), labelPoint);
                        isSpeedDisplayed = true;
                        labelPoint.Y += 25;
                    }
                    
                    Button slowDown = new Button();
                    slowDown.Click += SlowDownClick;
                    slowDown.Text = "SlowDown";
                    slowDown.Location = buttonPoint;
                    panel2.Controls.Add(slowDown);
                    buttonPoint.Y += 25;
                }
                else if (i.Equals(typeof(IRise)))
                {
                    IRise iRise = (IRise)selectedItem;
                    if (!isHeighDisplayed)
                    {
                        CreateLabel("Height: " + iRise.getHeight(), labelPoint);
                        isHeighDisplayed = true;
                        labelPoint.Y += 25;
                    }
                    
                    isHeighDisplayed = true;
                    Button rise = new Button();
                    rise.Click += RiseClick;
                    rise.Text = "Rise";
                    rise.Location = buttonPoint;
                    panel2.Controls.Add(rise);
                    buttonPoint.Y += 25;
                }
                else if (i.Equals(typeof(IDive)))
                {
                    IDive iDive = (IDive)selectedItem;
                    if (!isHeighDisplayed)
                    {
                        CreateLabel("Height: " + iDive.getHeight(), labelPoint);
                        isHeighDisplayed = true;
                        labelPoint.Y += 25;
                    }
                    
                    Button dive = new Button();
                    dive.Click += DiveClick;
                    dive.Text = "Dive";
                    dive.Location = buttonPoint;
                    panel2.Controls.Add(dive);
                    buttonPoint.Y += 25;
                }
                
            }

        }
        private void CreateLabel(String name, Point point)
        {
            Label label = new Label();
            label.Location = point;
            label.Text = name;
            panel.Controls.Add(label);
        }

        
        private void SlowDownClick(object sender, EventArgs e)
        {
            ISlowDown slowDown = (ISlowDown)objectComboBox.SelectedItem;
            slowDown.SlowDown(5);
            panel.GetChildAtPoint(new Point(0, 0)).Text = "Speed: " + slowDown.getSpeed() ;

        }
        
        private void AccelerateClick(object sender, EventArgs e)
        {
            IAccelerate accelerate = (IAccelerate)objectComboBox.SelectedItem;
            accelerate.Accelerate(5);
            panel.GetChildAtPoint(new Point(0, 0)).Text = "Speed: " + accelerate.getSpeed();

        }
        private void RiseClick(object sender, EventArgs e)
        {
            IRise irise = (IRise)objectComboBox.SelectedItem;
            irise.Rise(5);
            panel.GetChildAtPoint(new Point(0, 25)).Text = "Height: " + irise.getHeight();

        }
        private void DiveClick(object sender, EventArgs e)
        {
            IDive idive = (IDive)objectComboBox.SelectedItem;
            idive.Dive(5);
            panel.GetChildAtPoint(new Point(0, 25)).Text = "Height: " + idive.getHeight();

        }

    }
}
