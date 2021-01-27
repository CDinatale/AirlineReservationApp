using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationDecktopApp
{
    class ParticularFlightListViewItem : ListViewItem
    {
        Customer aCustomer;
        public ParticularFlightListViewItem(Customer c)
        {
            aCustomer = c;
            this.Text = Convert.ToString(c.getId());
            string[] customerRow = { c.getFirstName(), c.getLastName(), c.getPhone() };
            this.SubItems.AddRange(customerRow);
        }

        public int getID()
        {
            return aCustomer.getId();
        }
    }
}
