using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace RssReader
{
    // [MonoTouch.Foundation.Register("MyTableViewController")]
    public partial class MyTableViewController : UITableViewController
    {
        static NSString CellID = new NSString ("MyIdentifier");
        
        // Constructor invoked from the NIB loader
        public MyTableViewController (IntPtr p) : base (p)
        {
        }
        
        // The data source for our TableView
        class DataSource : UITableViewDataSource
        {
            MyTableViewController tvc;
            
            public DataSource (MyTableViewController tableViewController)
            {
                this.tvc = tableViewController;
            }
            
            public override int RowsInSection (UITableView tableView, int section)
            {
                return 1;
            }

            public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell (CellID);
                if (cell == null)
                {
                    cell = new UITableViewCell (UITableViewCellStyle.Default, CellID);
                }
            
                // Customize the cell here...
            
                return cell;
            }
        }
    
        // This class receives notifications that happen on the UITableView
        class TableDelegate : UITableViewDelegate
        {
            MyTableViewController tvc;

            public TableDelegate (MyTableViewController tableViewController)
            {
                this.tvc = tableViewController;
            }
            
            public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
            {
                Console.WriteLine ("Row selected {0}", indexPath.Row);
            }
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            TableView.Delegate = new TableDelegate (this);
            TableView.DataSource = new DataSource (this);
        }
    }
}

