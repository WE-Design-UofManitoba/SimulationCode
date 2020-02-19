/****************************************************/
// Filename: Boost.cs
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
  class Boost{
    //--Variables--//
    private double loadCurrent;
    private double turbineDiameter; //D*
    private double dcVoltage;

    public double calculateDrawCurrent(){
      double output = 4+4;
      return output;
    }

    public double calculateBCVoltage(){
      double output= 5+5;
      return output;
    }

    //setter methods
    public void setLoadCurrent(double value){loadCurrent = value;}
    public void setTurbineDiameter(double value){turbineDiameter = value;}
    public void setDCVoltagee(double value){dcVoltage = value;}

  }
}