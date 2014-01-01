//$Id$
package com.tts.dpattern.duck;

public class ModelDuck extends Duck{

	public ModelDuck(){
		quackBehavior = new Quack();
		flyBehavior = new FlyNoWay();
	}
	@Override
	public void display() {
		System.out.println(" I am Model Duck !");
	}

	
}
