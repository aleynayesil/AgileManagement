using AgileManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Domain.models
{
    public class Sprint:Entity
    {
        public string Name { get;private set; } = "Sprint-";
        public int SiraNo { get; private set; }
        public DateTime StartDate { get;private set; }
        public DateTime EndDate { get;private set; }
        public Project Project { get; private set; }

        public Sprint(DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid().ToString();
            SetDate(startDate, endDate);
        }

        public void SetSiraNo(int siraNo)
        {
            if (siraNo<=0)
            {
                throw new Exception("Sprint sıra no 0 dan büyük olmalıdır.");
            }
            SiraNo = siraNo;
        }
        public void SetDate(DateTime startDate, DateTime endDate)
        {
            if (startDate>endDate)
            {
                throw new Exception("Doğru zaman aralığı giriniz");
            }
            if ((endDate.Day - startDate.Day) > 14)
            {
                throw new Exception("14 günden fazla olamaz");
            }
            if (startDate<DateTime.Now)
            {
                throw new Exception("Doğru zaman aralığında bir gün seçiniz.");
            }
            StartDate = startDate;
            EndDate = endDate;
        }

    }
}
