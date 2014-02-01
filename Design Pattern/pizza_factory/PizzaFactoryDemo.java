//$Id$
package com.tts.dpbook.factory;

public class PizzaFactoryDemo {

	public static void main(String[] args){
		PizzaStore ps = new PizzaStore(new SimplePizzaFactory() );
		Pizza p =  ps.pizzaOrder("Cheese");
		
	}
}
