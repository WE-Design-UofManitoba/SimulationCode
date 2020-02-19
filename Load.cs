/****************************************************/
// Filename: Load.cs
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
  class Load{

     //--Variables--//
    private double loadResistance;
    private double bcVoltage;

    public double calculateDrawCurrent(){
      double output = 3+3;
      return output;
    }

    //setter methods
    public void setLoadResistance(double value){loadResistance = value;}
    public void setBCVoltage(double value){bcVoltage = value;}

  }
}