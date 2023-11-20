using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Utilities
{
    public class CustomAppointment : INotifyPropertyChanged
    {
        private DateTime start = DateTime.Now;
        private DateTime end = DateTime.Now;
        private string subject = string.Empty;
        private string description = string.Empty;
        private string location = string.Empty;
        private Guid id = Guid.NewGuid();
        private List<CustomAppointment> exceptions;
        public CustomAppointment()
        {
        }
        public CustomAppointment(DateTime start, DateTime end, string subject, string description, string location)
        {
            this.start = start;
            this.end = end;
            this.subject = subject;
            this.description = description;
            this.location = location;
            List<CustomAppointment> exceptions = new List<CustomAppointment>();
        }
        public List<CustomAppointment> Exceptions
        {
            get
            {
                return this.exceptions;
            }
            set
            {
                if (this.exceptions != value)
                {
                    this.exceptions = value;
                    this.OnPropertyChanged("Exceptions");
                }
            }
        }
        public Guid Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }
        public DateTime Start
        {
            get
            {
                return this.start;
            }
            set
            {
                if (this.start != value)
                {
                    this.start = value;
                    this.OnPropertyChanged("Start");
                }
            }
        }
        public DateTime End
        {
            get
            {
                return this.end;
            }
            set
            {
                if (this.end != value)
                {
                    this.end = value;
                    this.OnPropertyChanged("End");
                }
            }
        }
        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                if (this.subject != value)
                {
                    this.subject = value;
                    this.OnPropertyChanged("Subject");
                }
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (this.location != value)
                {
                    this.location = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
