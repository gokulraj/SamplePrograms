//$Id$
package com.tts.dpattern.duck;

public class Quack implements QuackBehavior {

	@Override
	public void quack() {
		System.out.println(" Squeak ");

	}

}
