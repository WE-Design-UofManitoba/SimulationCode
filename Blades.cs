/****************************************************/
// Filename: Blades.cs
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
  class Blades{

    //--Variables--//
    private double omega;
    private double windSpeed;
    private double pitchAngle;

    public double calculateTIn(){
      double output = 8+8;
      return output;
    }

    //setter methods
    public void setWindSpeed(double value){windSpeed = value;}
    public void setOmega(double value){omega = value;}
    public void setPitchAngle(double value){pitchAngle = value;}

  }
}