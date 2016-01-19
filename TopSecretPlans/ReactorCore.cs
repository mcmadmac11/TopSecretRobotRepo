using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    class ReactorCore : IChangeTemperature
    {
        public int Temperature;
        int fuelRods;
        int fuelRodLevel;
        int controlRods;
        int controlRodLevel;
        int waterReactorLevel;
        int uraniumAmount;
        int boronAmount;

        public ReactorCore()
        {
            IChangeTemperature tempChange = new ReactorCore();
            tempChange.coolDown = 500;
            tempChange.heatUp = 100;
            
        }

        public ReactorCore(int FuelRods, int FuelRodLevel, int ControlRods, int ControlRodLevel, int WaterReactorLevel, int UraniumAmount, int BoronAmount)
        {
            this.fuelRods = FuelRods;
            this.fuelRodLevel = FuelRodLevel;
            this.controlRods = ControlRods;
            this.controlRodLevel = ControlRodLevel;
            this.waterReactorLevel = WaterReactorLevel;
            this.uraniumAmount = UraniumAmount;
            this.boronAmount = BoronAmount;

            

        }





        public int coolDown
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int heatUp
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        List<int> evasionCheckList;

        public void  EvasionCheck(int fuelRods, int fuelRodLevel, int controlRods, int controlRodLevel, int waterReactorLevel, int uraniumAmount, int boronAmount )
        {
            if  (evasionCheckList != null)
            {

                //iterate through to make sure evasive action can be taken safely
                List<int> EvasionCheckList = evasionCheckList;
                EvasionCheckList.Add(fuelRods);
                EvasionCheckList.Add(fuelRodLevel);
                EvasionCheckList.Add(controlRods);
                EvasionCheckList.Add(controlRodLevel);
                EvasionCheckList.Add(waterReactorLevel);
                EvasionCheckList.Add(uraniumAmount);
                EvasionCheckList.Add(boronAmount);

                
            }
            
        }

       
    }
}
