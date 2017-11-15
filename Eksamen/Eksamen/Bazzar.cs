using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
    class Bazzar
    {
        private Boolean Finished;
        private int ItemNumber;
        private Boolean ItemAvailable;

        public Bazzar()
        {
            SetFinished(false);
            SetItemNumber(0);
            SetItemAvailable(false);


        }

        public void SetFinished(Boolean Finished)
        {
            this.Finished = Finished;
        }

        public void SetItemNumber(int ItemNumber)
        {
            this.ItemNumber = ItemNumber;
        }

        public void SetItemAvailable(Boolean ItemAvailable)
        {
            this.ItemAvailable = ItemAvailable;
        }

        public Boolean GetFinished()
        {
            return Finished;
        }

        public int GetItemNumber()
        {
            return ItemNumber;
        }

        public Boolean GetItemAvailable()
        {
            return ItemAvailable;
        }
    }
}
