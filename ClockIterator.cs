/****************************************************/
// Filename: ClockIterator.cs
// Created: Eli Fridlender
// Change history:
// 03/05/2020 / Ben Gibson
//
/****************************************************/
//Purpose: TODO

/****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockIterator.cs{

  class ClockIterator{

    //--Variables--//
    private double deltaT;		//set in constructor
    private double Tdraw;		//variable
    private double Tin;			//variable
	private double omega;		//variable
	private Blades rotor;		//set in constructor
	private Generator gen;		//set in constructor
	
	public ClockIterator(double dt, Blades r, Generator g) {
		deltaT = dt;
		rotor = r;
		gen = g;
	}

	public void step() {
		Tin = rotor.calcT(omega);
		Tdraw = gen.calcT(omega);
		omega = omega + (Tin - Tdraw)/gen.J;
		return;
	}

    public double getOmega(){
      return omega;
    }

    //setter methods
    public void setDeltaT(double value){deltaT = value;}
    public void setTdraw(double value){Tdraw = value;}
    public void setTin(double value){Tin = value;}
  }
}