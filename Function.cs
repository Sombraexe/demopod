using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demopod
{
    class Function
    {
        public void InsertOrganizer(string Lastname, string Name, string Patronymic, DateTime Data_Birth, decimal Phone_Number, int ID_Event, int ID_Organization)
        {
            TicketDataSetTableAdapters.OrganizerTableAdapter organizerAdapter = new TicketDataSetTableAdapters.OrganizerTableAdapter();
            organizerAdapter.Insert(Lastname, Name, Patronymic, Data_Birth, Phone_Number,ID_Organization);
        }


        public void UpdateOrganizer(TicketDataSet.OrganizerRow OrganizerRow)
        {
            TicketDataSetTableAdapters.OrganizerTableAdapter organizAdapter = new TicketDataSetTableAdapters.OrganizerTableAdapter();
            organizAdapter.Update(OrganizerRow);
        }


        public void AddCategoryEvent(int ID, string Event_Name, int ID_Organizer, int ID_Location)
        {
            TicketDataSetTableAdapters.EventTableAdapter EventAdapter = new TicketDataSetTableAdapters.EventTableAdapter();
            EventAdapter.Insert(ID, Event_Name, ID_Organizer, ID_Location);
        }

        public void EditCategoryEvent(TicketDataSet.EventRow eventrow)
        {
            TicketDataSetTableAdapters.EventTableAdapter eventAdapter = new TicketDataSetTableAdapters.EventTableAdapter();
            eventAdapter.Update(eventrow);
        }

        public void AddLocation(int ID, string Country, string City, string Street, string House, string Hall)
        {
            TicketDataSetTableAdapters.LocationTableAdapter locationAdapter = new TicketDataSetTableAdapters.LocationTableAdapter();
            locationAdapter.Insert(ID, Country, City, Street, House, Hall);
        }

         




    }
}
