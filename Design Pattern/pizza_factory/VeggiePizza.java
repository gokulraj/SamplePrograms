//$Id$
package com.tts.dpbook.factory;

public class VeggiePizza implements Pizza {

	public VeggiePizza(){
		System.out.println(" VeggiePizza ");
	}
	@Override
	public void prepare() {
		// TODO Auto-generated method stub
		System.out.println(" Prepared ");
	}

	@Override
	public void bake() {
		// TODO Auto-generated method stub
		System.out.println(" bake ");
	}

	@Override
	public void cut() {
		// TODO Auto-generated method stub
		System.out.println(" cut ");
	}

	@Override
	public void box() {
		// TODO Auto-generated method stub
		System.out.println(" box ");
	}

}
