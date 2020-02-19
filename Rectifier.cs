/****************************************************/
// Filename: Recitifier.cs
// Created: Eli Fridlender
// Change history:
// 02/19/2020 / Eli Fridlender
//
/****************************************************/
//Purpose: TODO

/****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindTurbineSimulator{
  class Rectifier{

    //-- Variables --//
    private double drawCurrent;
    private double rmsVoltage;

    // ---DUMMY FUNCTION FOR RMSCURRENT--- //
    public double calculateRMSCurrent(){
      double output = 1+1;
      return output;
    }
    // ---DUMMY FUNCTION FOR DCVOLTAGE--- //
    public double calculateDCVoltage(){
      double output = 2+2;
      return output;
    }

    //setter methods
    public void setDrawCurrent(double value){ drawCurrent = value;}
    public void setRMSVoltage(double value){ rmsVoltage = value;}









  }
}