/****************************************************/
// Filename: Generator.cs
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
  class Generator{
    private double omega;
    private double rmsCurrent;

    public double calculateTDraw(){
      double output = 6+6;
      return output;
    }

    public double calculateRMSVoltage(){
      double output = 7+7;
      return output;
    }

    //setter methods
    public void setRMSCurrent(double value){rmsCurrent = value;}
    public void setOmega(double value){omega = value;}



  }
}