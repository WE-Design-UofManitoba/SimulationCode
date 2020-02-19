/****************************************************/
// Filename: InputProcessor.cs
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
  class InputProcessor{

    //Input condition variables
    private double time;
    private double windVelocity;
    private double beta;
    private double loadR;
    private double bladeDiameter;

    private void setVariables(){
      time = 1.2;
      windVelocity = 2.1;
      beta = 2.3;
      loadR = 3.4;
      bladeDiameter = 12.2;
    }

    //Getter methods for input variables
    public double getTime(){
      return time;
    }
    public double getWindVelocity(){
      return windVelocity;
    }
    public double getBeta(){
      return beta;
    }
    public double getLoadR(){
      return loadR;
    }
    public double getBladeDiameter(){
      return bladeDiameter;
    }

  }
}