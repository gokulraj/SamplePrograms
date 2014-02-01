//$Id$
package com.tts.dpbook.factory;

public class PizzaStore {
		SimplePizzaFactory factory;
	
		public PizzaStore(SimplePizzaFactory f){
			this.factory = f;
		}
		
		public Pizza pizzaOrder(String type){
			Pizza pizza;
			
			pizza = factory.createPizza(type);
			
			return pizza;
			
		}
}
